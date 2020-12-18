package org.noodle.service.dictionary;

import com.github.pagehelper.PageHelper;
import org.noodle.bean.dictionary.select.DictionarySearchPublicDto;
import org.noodle.bean.dictionary.select.DictionarySearchPublicRequest;
import org.noodle.beans.NoodleException;
import org.noodle.orm.mapper.DictionaryMapper;
import org.noodle.orm.mapper.UserDictionaryMapper;
import org.noodle.orm.model.Dictionary;
import org.noodle.orm.model.UserDictionary;
import org.noodle.service.NoodlePostService;
import org.springframework.stereotype.Service;
import org.springframework.util.Assert;
import org.springframework.util.StringUtils;

import javax.annotation.Resource;
import java.util.List;
import java.util.stream.Collectors;

/**
 * 公用字典搜索服务
 * @author wanghy
 */
@Service("dictionary.search")
public class DictionarySearchPublicService implements NoodlePostService<DictionarySearchPublicRequest, List<DictionarySearchPublicDto>> {
    @Resource
    private DictionaryMapper dictionaryMapper;

    @Resource
    private UserDictionaryMapper userDictionaryMapper;

    @Override
    public Class<DictionarySearchPublicRequest> getRequestClass() {
        return DictionarySearchPublicRequest.class;
    }

    @Override
    public List<DictionarySearchPublicDto> execute(DictionarySearchPublicRequest request) throws NoodleException {
        Assert.isTrue(StringUtils.hasText(request.getNameCondition()), "请输入要查询的字典名称");

        int pageSize = request.getPageSize()==null?50: request.getPageSize();
        int pageNum = request.getPageNum()==null?1:request.getPageNum();

        String nameCondition = "%" + request.getNameCondition() + "%";

        PageHelper.startPage(pageNum, pageSize, false);
        List<Dictionary> dictionaryList = dictionaryMapper.selectPublicByCondition(nameCondition);

        return dictionaryList.parallelStream()
                .map(dictionary -> convertToDto(request.getUserId(), dictionary))
                .collect(Collectors.toList());
    }

    private DictionarySearchPublicDto convertToDto(Long userId, Dictionary dictionary) {
        DictionarySearchPublicDto dto = new DictionarySearchPublicDto();
        dto.setId(dictionary.getId());
        dto.setName(dictionary.getName());
        dto.setPublisher(dto.getPublisher());
        dto.setSelected(isSelected(userId, dictionary.getId()));

        return dto;
    }

    /**
     * 判断一个字典是否已经被选定过
     * @param userId 用户id
     * @param dictionaryId 字典id
     */
    private boolean isSelected(Long userId, long dictionaryId) {
        PageHelper.startPage(1, 1, false);
        UserDictionary userDictionary = userDictionaryMapper.selectByUserAndDictionary(userId, dictionaryId);
        return userDictionary!=null;
    }
}
