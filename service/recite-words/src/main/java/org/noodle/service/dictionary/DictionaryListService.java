package org.noodle.service.dictionary;

import com.github.pagehelper.PageHelper;
import org.noodle.bean.dictionary.DictionaryListRequest;
import org.noodle.beans.NoodleException;
import org.noodle.orm.mapper.DictionaryMapper;
import org.noodle.orm.model.Dictionary;
import org.noodle.service.NoodlePostService;
import org.springframework.stereotype.Service;

import javax.annotation.Resource;
import java.util.List;

/**
 * 字典查询服务
 * @author wanghy
 */
@Service("dictionary.list")
public class DictionaryListService implements NoodlePostService<DictionaryListRequest, List<Dictionary>> {
    @Resource
    private DictionaryMapper dictionaryMapper;

    @Override
    public Class<DictionaryListRequest> getRequestClass() {
        return DictionaryListRequest.class;
    }

    @Override
    public List<Dictionary> execute(DictionaryListRequest request) throws NoodleException {
        int pageSize = request.getPageSize()==null?50: request.getPageSize();
        int pageNum = request.getPageNum()==null?1:request.getPageNum();

        PageHelper.startPage(pageNum, pageSize, false);
        return dictionaryMapper.selectAllByUser(request.getUserId());
    }
}
