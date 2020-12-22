package org.noodle.service.review;

import cn.hutool.core.lang.Assert;
import org.noodle.bean.review.ReviewAddRequest;
import org.noodle.beans.NoodleException;
import org.noodle.orm.mapper.ReviewMapper;
import org.noodle.orm.mapper.ReviewWordsMapper;
import org.noodle.orm.mapper.VocabularyMapper;
import org.noodle.orm.model.Review;
import org.noodle.orm.model.ReviewWords;
import org.noodle.orm.model.Vocabulary;
import org.noodle.service.NoodlePostService;
import org.noodle.util.id.SnowFlake;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Propagation;
import org.springframework.transaction.annotation.Transactional;

import javax.annotation.Resource;
import java.util.List;
import java.util.stream.Collectors;

/**
 * 复习记录增加服务
 * @author wanghy
 */
@Service("review.add")
public class ReviewAddService implements NoodlePostService<ReviewAddRequest, Object> {
    @Resource
    private VocabularyMapper vocabularyMapper;

    @Resource
    private ReviewMapper reviewMapper;

    @Resource
    private ReviewWordsMapper reviewWordsMapper;

    @Resource
    private SnowFlake snowFlake;

    @Override
    public Class<ReviewAddRequest> getRequestClass() {
        return ReviewAddRequest.class;
    }

    @Transactional(propagation = Propagation.REQUIRED, rollbackFor = {Exception.class,NoodleException.class,RuntimeException.class})
    @Override
    public Object execute(ReviewAddRequest request) throws NoodleException {
        Assert.notNull(request.getId(), "复习id不能为空");
        Assert.notEmpty(request.getVocabularyIds(), "复习词汇列表不能为空");

        Review review = reviewMapper.selectByPrimaryKey(request.getId());
        //已有记录说明已经保存过, 直接返回成功
        if (review!=null) {
            return null;
        }

        //取当前时间
        long reviewTime = System.currentTimeMillis();

        // 获取并调整词汇的复习次数以及后续的复习时间
        List<Vocabulary> vocabularyList = request.getVocabularyIds().stream()
                .map(id->loadAndTuneVocabulary(reviewTime, id))
                .collect(Collectors.toList());

        //生成复习记录
        review = new Review();
        review.setId(request.getId());
        review.setUserId(request.getUserId());
        review.setReviewTime(reviewTime);
        review.setComment(request.getComment());
        reviewMapper.insert(review);

        for (Vocabulary vocabulary:vocabularyList) {
            //更新词汇的已复习记录以及后续预计复习时间
            vocabularyMapper.updateByPrimaryKey(vocabulary);

            //生成复习单词记录
            ReviewWords reviewWords = new ReviewWords();
            reviewWords.setId(snowFlake.nextId());
            reviewWords.setReviewId(request.getId());
            reviewWords.setWordsId(vocabulary.getWordsId());
            reviewWordsMapper.insert(reviewWords);
        }

        return null;
    }

    /**
     * 获取并调整词汇的复习次数以及后续的复习时间
     * @param reviewTime 复习时间
     * @param vocabularyId 词汇id
     */
    private Vocabulary loadAndTuneVocabulary(long reviewTime, long vocabularyId) {
        Vocabulary vocabulary = vocabularyMapper.selectByPrimaryKey(vocabularyId);
        vocabulary.setReviewTime(vocabulary.getReviewTime()+1);

        if (vocabulary.getReviewTime()==1) {
            long diff = reviewTime - vocabulary.getReviewScheduleTime1();
            vocabulary.setReviewScheduleTime2(vocabulary.getReviewScheduleTime2()+diff);
            vocabulary.setReviewScheduleTime3(vocabulary.getReviewScheduleTime3()+diff);
            vocabulary.setReviewScheduleTime4(vocabulary.getReviewScheduleTime4()+diff);
        }
        else if (vocabulary.getReviewTime()==2) {
            long diff = reviewTime - vocabulary.getReviewScheduleTime2();
            vocabulary.setReviewScheduleTime3(vocabulary.getReviewScheduleTime3()+diff);
            vocabulary.setReviewScheduleTime4(vocabulary.getReviewScheduleTime4()+diff);
        }
        else if (vocabulary.getReviewTime()==3) {
            long diff = reviewTime - vocabulary.getReviewScheduleTime3();
            vocabulary.setReviewScheduleTime4(vocabulary.getReviewScheduleTime4()+diff);
        }

        return vocabulary;
    }
}
