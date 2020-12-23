package org.noodle.service.exercise;

import org.noodle.bean.exercise.ExerciseScoreRequest;
import org.noodle.beans.NoodleException;
import org.noodle.orm.mapper.ExerciseMapper;
import org.noodle.orm.mapper.ExerciseWordsMapper;
import org.noodle.orm.mapper.VocabularyMapper;
import org.noodle.orm.model.Exercise;
import org.noodle.orm.model.ExerciseWords;
import org.noodle.orm.model.Vocabulary;
import org.noodle.service.NoodlePostService;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Propagation;
import org.springframework.transaction.annotation.Transactional;
import org.springframework.util.Assert;

import javax.annotation.Resource;

/**
 * 测验打分服务
 * @author wanghy
 */
@Service("exercise.score")
public class ExerciseScoreService implements NoodlePostService<ExerciseScoreRequest, Object> {
    @Resource
    private ExerciseMapper exerciseMapper;

    @Resource
    private ExerciseWordsMapper exerciseWordsMapper;

    @Resource
    private VocabularyMapper vocabularyMapper;

    @Override
    public Class<ExerciseScoreRequest> getRequestClass() {
        return ExerciseScoreRequest.class;
    }

    @Transactional(propagation = Propagation.REQUIRED, rollbackFor = {Exception.class,NoodleException.class,RuntimeException.class})
    @Override
    public Object execute(ExerciseScoreRequest request) throws NoodleException {
        Assert.notNull(request.getId(), "测验id不能为空");
        Assert.notNull(request.getExerciseWords(), "测验打分记录不能为空");
        Assert.notEmpty(request.getExerciseWords(), "测验打分记录不能为空");
        for (ExerciseWords exerciseWords:request.getExerciseWords()) {
            Assert.notNull(exerciseWords.getId(), "测验打分记录行id不能为空");
            Assert.notNull(exerciseWords.getCorrect(), "测验打分记录行打分记录不能为空");
        }

        //取当前时间
        long currentTime = System.currentTimeMillis();

        //保存打分记录
        int totalCorrect = 0;
        for (ExerciseWords exerciseWords:request.getExerciseWords()) {
            ExerciseWords dbExerciseWords = exerciseWordsMapper.selectByPrimaryKey(exerciseWords.getId());
            dbExerciseWords.setCorrect(exerciseWords.getCorrect());

            exerciseWordsMapper.updateByPrimaryKey(dbExerciseWords);

            //答题错误时, 重置词汇记录为需要复习状态
            if (exerciseWords.getCorrect()==0) {
                resetVocabulary(dbExerciseWords.getVocabularyId(), currentTime);
            }
            else {
                totalCorrect ++;
            }
        }
        Exercise exercise = exerciseMapper.selectByPrimaryKey(request.getId());
        exercise.setScore(totalCorrect*100/request.getExerciseWords().size());
        exerciseMapper.updateByPrimaryKey(exercise);

        return null;
    }

    /**
     * 重置词汇记录为需要复习状态
     * @param vocabularyId 词汇id
     * @param currentTime 当前时间
     */
    private void resetVocabulary(long vocabularyId, long currentTime) {
        Vocabulary vocabulary = vocabularyMapper.selectByPrimaryKey(vocabularyId);

        vocabulary.setReviewTime(0);
        //预计首次复习时间等于当前时间加1天减8小时, 减8小时的目的是可以相对较早的打印复习单词
        //后续的时间用首次复习时间加上差值
        vocabulary.setReviewScheduleTime4(currentTime + vocabulary.getReviewScheduleTime4() - vocabulary.getReviewScheduleTime1() + 86400000L - 28800000L);
        vocabulary.setReviewScheduleTime3(currentTime + vocabulary.getReviewScheduleTime3() - vocabulary.getReviewScheduleTime1() + 86400000L - 28800000L);
        vocabulary.setReviewScheduleTime2(currentTime + vocabulary.getReviewScheduleTime2() - vocabulary.getReviewScheduleTime1() + 86400000L - 28800000L);
        vocabulary.setReviewScheduleTime1(currentTime + 86400000L - 28800000L);

        vocabularyMapper.updateByPrimaryKey(vocabulary);
    }
}
