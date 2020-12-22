package org.noodle.service.words;

import org.noodle.bean.words.WordsSaveRequest;
import org.noodle.beans.NoodleException;
import org.noodle.orm.mapper.WordsMapper;
import org.noodle.service.NoodlePostService;
import org.springframework.stereotype.Service;
import org.springframework.util.Assert;
import org.springframework.util.StringUtils;

import javax.annotation.Resource;

/**
 * 单词保存服务
 * @author wanghy
 */
@Service("words.save")
public class WordsSaveService implements NoodlePostService<WordsSaveRequest, Object>  {
    @Resource
    private WordsMapper wordsMapper;

    @Override
    public Class<WordsSaveRequest> getRequestClass() {
        return WordsSaveRequest.class;
    }

    @Override
    public Object execute(WordsSaveRequest request) throws NoodleException {
        Assert.notNull(request.getWords(), "传入的单词对象不能为空");
        Assert.isTrue(request.getWords().getId()>0, "请传入有效的id");
        Assert.isTrue(StringUtils.hasText(request.getWords().getSpelling()), "单词拼写不能为空");
        Assert.isTrue(StringUtils.hasText(request.getWords().getExplanation()), "单词释义不能为空");
        int updateCount = wordsMapper.updateByPrimaryKey(request.getWords());
        if (updateCount==0) {
            wordsMapper.insert(request.getWords());
        }

        return null;
    }
}
