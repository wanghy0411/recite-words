package org.noodle.service.dictionary;

import org.noodle.bean.dictionary.DictionarySelectRequest;
import org.noodle.beans.NoodleException;
import org.noodle.orm.mapper.UserDictionaryMapper;
import org.noodle.orm.model.UserDictionary;
import org.noodle.service.NoodlePostService;
import org.noodle.util.id.SnowFlake;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Propagation;
import org.springframework.transaction.annotation.Transactional;

import javax.annotation.Resource;

/**
 * 用户选定使用字典服务
 * @author wanghy
 */
@Service("dictionary.select")
public class DictionarySelectService implements NoodlePostService<DictionarySelectRequest, Object> {
    @Resource
    private UserDictionaryMapper userDictionaryMapper;

    @Resource
    private SnowFlake snowFlake;

    @Override
    public Class<DictionarySelectRequest> getRequestClass() {
        return DictionarySelectRequest.class;
    }

    @Transactional(propagation = Propagation.REQUIRED, rollbackFor = {Exception.class,NoodleException.class,RuntimeException.class})
    @Override
    public Object execute(DictionarySelectRequest request) throws NoodleException {
        UserDictionary userDictionary = userDictionaryMapper.selectByUserAndDictionary(request.getUserId(), request.getDictionaryId());
        if (userDictionary==null) {
            userDictionary = new UserDictionary();
            userDictionary.setId(snowFlake.nextId());
            userDictionary.setUserId(request.getUserId());
            userDictionary.setDictionaryId(request.getDictionaryId());
            userDictionaryMapper.insert(userDictionary);
        }

        return null;
    }
}
