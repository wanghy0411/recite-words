package org.noodle.service.words;

import cn.hutool.core.lang.Assert;
import com.github.pagehelper.PageHelper;
import org.noodle.bean.words.list.WordsListRequest;
import org.noodle.beans.NoodleException;
import org.noodle.orm.mapper.WordsMapper;
import org.noodle.orm.model.Words;
import org.noodle.service.NoodlePostService;
import org.springframework.stereotype.Service;

import javax.annotation.Resource;
import java.util.List;

/**
 * 单词列表查询服务
 * @author wanghy
 */
@Service("words.list")
public class WordsListService implements NoodlePostService<WordsListRequest, List<Words>> {
    @Resource
    private WordsMapper wordsMapper;

    @Override
    public Class<WordsListRequest> getRequestClass() {
        return WordsListRequest.class;
    }

    @Override
    public List<Words> execute(WordsListRequest request) throws NoodleException {
        Assert.notNull(request.getDictionaryId(), "字典id不能为空");

        int pageSize = request.getPageSize()==null?100: request.getPageSize();
        int pageNum = request.getPageNum()==null?1:request.getPageNum();

        PageHelper.startPage(pageNum, pageSize, false);
        return wordsMapper.selectByDictionaryId(request.getDictionaryId());
    }
}
