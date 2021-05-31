package org.noodle.service.recite;

import cn.hutool.core.lang.Assert;
import com.github.pagehelper.Page;
import com.github.pagehelper.PageHelper;
import org.noodle.bean.recite.ReciteAddRequest;
import org.noodle.beans.NoodleException;
import org.noodle.orm.mapper.ReciteMapper;
import org.noodle.orm.mapper.ReciteWordsMapper;
import org.noodle.orm.mapper.VocabularyMapper;
import org.noodle.orm.mapper.WordsMapper;
import org.noodle.orm.model.Recite;
import org.noodle.orm.model.ReciteWords;
import org.noodle.orm.model.Vocabulary;
import org.noodle.orm.model.Words;
import org.noodle.service.NoodlePostService;
import org.noodle.util.id.SnowFlake;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Propagation;
import org.springframework.transaction.annotation.Transactional;

import javax.annotation.Resource;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;

/**
 * 背诵记录增加服务
 * @author wanghy
 */
@Service("recite.add")
public class ReciteAddService implements NoodlePostService<ReciteAddRequest, Object> {
    @Resource
    private ReciteMapper reciteMapper;

    @Resource
    private ReciteWordsMapper reciteWordsMapper;

    @Resource
    private VocabularyMapper vocabularyMapper;

    @Resource
    private WordsMapper wordsMapper;

    @Resource
    private SnowFlake snowFlake;

    @Override
    public Class<ReciteAddRequest> getRequestClass() {
        return ReciteAddRequest.class;
    }

    @Transactional(propagation = Propagation.REQUIRED, rollbackFor = {Exception.class,NoodleException.class,RuntimeException.class})
    @Override
    public Object execute(ReciteAddRequest request) throws NoodleException {
        Assert.notNull(request.getId(), "背诵id不能为空");

        Recite recite = reciteMapper.selectByPrimaryKey(request.getId());
        //已有记录说明已经保存过, 直接返回成功
        if (recite!=null) {
            return null;
        }

        //取可背诵的单词数
        Page<Words> page = PageHelper.startPage(1, 1, true);
        wordsMapper.selectNewWords(request.getUserId());
        long totalWords = page.getTotal();
        Assert.isTrue(totalWords > 0, "已经没有单词可背了");

        //取本次背诵的单词列表
        List<Words> wordsList;
        int wordsNumber = request.getWordsNumber()==null?20: request.getWordsNumber();

        if (totalWords <= wordsNumber) {
            PageHelper.startPage(1, wordsNumber, false);
            wordsList = wordsMapper.selectNewWords(request.getUserId());
        }
        else {
            List<Integer> numList = new ArrayList<>();
            for (int i = 0; i < wordsNumber; i++) {
                int pageNum = -1;

                while (pageNum < 0) {
                    Random random = new Random();
                    pageNum = random.nextInt((int) totalWords);

                    if (numList.contains(pageNum)) {
                        pageNum = -1;
                    }
                }

                numList.add(pageNum);
            }

            wordsList = new ArrayList<>();
            for (Integer pageNum : numList) {
                PageHelper.startPage(pageNum, 1, true);
                List<Words> tmpWordsList = wordsMapper.selectNewWords(request.getUserId());
                wordsList.addAll(tmpWordsList);
            }
        }
        //计算当天0点的时间戳以及后续4次复习的时间戳
        int schedule1 = request.getSchedule1()==null?1: request.getSchedule1();
        int schedule2 = request.getSchedule2()==null?7: request.getSchedule2();
        int schedule3 = request.getSchedule3()==null?30: request.getSchedule3();
        int schedule4 = request.getSchedule4()==null?90: request.getSchedule4();
        long now = System.currentTimeMillis();

        //复习时间等于计划的天数减8小时, 减8小时的目的是可以相对较早的打印复习单词
        long time1 = now + 86400000L * schedule1 - 28800000L;
        long time2 = now + 86400000L * schedule2 - 28800000L;
        long time3 = now + 86400000L * schedule3 - 28800000L;
        long time4 = now + 86400000L * schedule4 - 28800000L;

        //先形成所有对象, 最后一并提交数据库, 以减小事务
        recite = new Recite();
        recite.setId(request.getId());
        recite.setUserId(request.getUserId());
        recite.setReciteTime(now);
        recite.setComment(request.getComment());
        List<ReciteWords> reciteWordsList = new ArrayList<>();
        List<Vocabulary> vocabularyList = new ArrayList<>();
        for (Words words : wordsList) {
            ReciteWords reciteWords = new ReciteWords();
            reciteWords.setId(snowFlake.nextId());
            reciteWords.setReciteId(recite.getId());
            reciteWords.setWordsId(words.getId());
            reciteWordsList.add(reciteWords);

            Vocabulary vocabulary = new Vocabulary();
            vocabulary.setId(snowFlake.nextId());
            vocabulary.setUserId(request.getUserId());
            vocabulary.setWordsId(words.getId());
            vocabulary.setReviewTime(0);
            vocabulary.setReviewScheduleTime1(time1);
            vocabulary.setReviewScheduleTime2(time2);
            vocabulary.setReviewScheduleTime3(time3);
            vocabulary.setReviewScheduleTime4(time4);
            vocabularyList.add(vocabulary);
        }

        //保存记录
        reciteMapper.insert(recite);
        for (ReciteWords reciteWords:reciteWordsList) {
            reciteWordsMapper.insert(reciteWords);
        }
        for (Vocabulary vocabulary:vocabularyList) {
            vocabularyMapper.insert(vocabulary);
        }

        return null;
    }
}
