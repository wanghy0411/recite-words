package org.noodle.service.exercise;

import cn.hutool.core.lang.Assert;
import org.noodle.bean.exercise.ExerciseAddRequest;
import org.noodle.beans.NoodleException;
import org.noodle.orm.mapper.ExerciseMapper;
import org.noodle.orm.mapper.ExerciseWordsMapper;
import org.noodle.orm.model.Exercise;
import org.noodle.orm.model.ExerciseWords;
import org.noodle.service.NoodlePostService;
import org.noodle.util.id.SnowFlake;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Propagation;
import org.springframework.transaction.annotation.Transactional;

import javax.annotation.Resource;

/**
 * 复习记录增加服务
 * @author wanghy
 */
@Service("exercise.add")
public class ExerciseAddService implements NoodlePostService<ExerciseAddRequest, Object> {
    @Resource
    private ExerciseMapper exerciseMapper;

    @Resource
    private ExerciseWordsMapper exerciseWordsMapper;

    @Resource
    private SnowFlake snowFlake;

    @Override
    public Class<ExerciseAddRequest> getRequestClass() {
        return ExerciseAddRequest.class;
    }

    @Transactional(propagation = Propagation.REQUIRED, rollbackFor = {Exception.class,NoodleException.class,RuntimeException.class})
    @Override
    public Object execute(ExerciseAddRequest request) throws NoodleException {
        Assert.notNull(request.getId(), "测验id不能为空");
        Assert.notEmpty(request.getVocabularyIds(), "测验词汇列表不能为空");

        Exercise exercise = exerciseMapper.selectByPrimaryKey(request.getId());
        //已有记录说明已经保存过, 直接返回成功
        if (exercise!=null) {
            return null;
        }

        //生成测验记录
        exercise = new Exercise();
        exercise.setId(request.getId());
        exercise.setUserId(request.getUserId());
        exercise.setExerciseTime(System.currentTimeMillis());
        exercise.setComment(request.getComment());
        exerciseMapper.insert(exercise);

        //生成测验明细
        for (int i=0,size=request.getVocabularyIds().size();i<size;i++) {
            ExerciseWords exerciseWords = new ExerciseWords();
            exerciseWords.setId(snowFlake.nextId());
            exerciseWords.setExerciseId(request.getId());
            exerciseWords.setLineNumber(i+1);
            exerciseWords.setVocabularyId(request.getVocabularyIds().get(i));
            exerciseWordsMapper.insert(exerciseWords);
        }

        return null;
    }
}
