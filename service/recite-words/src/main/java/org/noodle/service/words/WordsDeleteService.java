package org.noodle.service.words;

import com.github.pagehelper.PageHelper;
import org.noodle.bean.words.WordsDeleteRequest;
import org.noodle.beans.NoodleException;
import org.noodle.orm.mapper.VocabularyMapper;
import org.noodle.orm.mapper.WordsMapper;
import org.noodle.orm.model.Vocabulary;
import org.noodle.service.NoodlePostService;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Propagation;
import org.springframework.transaction.annotation.Transactional;
import org.springframework.util.Assert;

import javax.annotation.Resource;
import java.util.List;

/**
 * 单词删除服务
 * @author wanghy
 */
@Service("words.delete")
public class WordsDeleteService implements NoodlePostService<WordsDeleteRequest, Object> {
    @Resource
    private WordsMapper wordsMapper;

    @Resource
    private VocabularyMapper vocabularyMapper;

    @Override
    public Class<WordsDeleteRequest> getRequestClass() {
        return WordsDeleteRequest.class;
    }

    @Transactional(propagation = Propagation.REQUIRED, rollbackFor = {Exception.class,NoodleException.class,RuntimeException.class})
    @Override
    public Object execute(WordsDeleteRequest request) throws NoodleException {
        Assert.notNull(request.getWordsId(), "传入的单词id不能为空");
        Assert.isTrue(request.getWordsId()>0, "请传入有效的单词id");

        PageHelper.startPage(1, 1, false);
        List<Vocabulary> vocabularyList = vocabularyMapper.selectByWordsId(request.getWordsId());
        Assert.isTrue(vocabularyList.isEmpty(), "单词已被使用, 不能删除");

        wordsMapper.deleteByPrimaryKey(request.getWordsId());

        return null;
    }
}
