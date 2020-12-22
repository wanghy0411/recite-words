package org.noodle.service.dictionary;

import com.github.pagehelper.PageHelper;
import org.noodle.bean.dictionary.DictionaryDeleteRequest;
import org.noodle.beans.NoodleException;
import org.noodle.orm.mapper.DictionaryMapper;
import org.noodle.orm.mapper.UserDictionaryMapper;
import org.noodle.orm.mapper.UserInfoMapper;
import org.noodle.orm.mapper.WordsMapper;
import org.noodle.orm.model.Dictionary;
import org.noodle.orm.model.UserInfo;
import org.noodle.orm.model.Words;
import org.noodle.service.NoodlePostService;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Propagation;
import org.springframework.transaction.annotation.Transactional;
import org.springframework.util.Assert;

import javax.annotation.Resource;
import java.util.List;

/**
 * 字典删除服务
 * @author wanghy
 */
@Service("dictionary.delete")
public class DictionaryDeleteService implements NoodlePostService<DictionaryDeleteRequest, Object> {
    @Resource
    private DictionaryMapper dictionaryMapper;

    @Resource
    private WordsMapper wordsMapper;

    @Resource
    private UserDictionaryMapper userDictionaryMapper;

    @Resource
    private UserInfoMapper userInfoMapper;

    @Override
    public Class<DictionaryDeleteRequest> getRequestClass() {
        return DictionaryDeleteRequest.class;
    }

    @Transactional(propagation = Propagation.REQUIRED, rollbackFor = {Exception.class,NoodleException.class,RuntimeException.class})
    @Override
    public Object execute(DictionaryDeleteRequest request) throws NoodleException {
        Assert.notNull(request.getDictionaryId(), "传入的字典id不能为空");
        Assert.isTrue(request.getDictionaryId()>0, "请传入有效的字典id");

        Dictionary dictionary = dictionaryMapper.selectByPrimaryKey(request.getDictionaryId());
        Assert.notNull(dictionary, "传入的字典不存在");

        //用于判断是否只是删除用户绑定字典的关系, 为true时需要实际删除字典
        boolean realDeleteDictionary = true;
        if ("Y".equals(dictionary.getPublicFlag())) {
            UserInfo userInfo = userInfoMapper.selectByPrimaryKey(request.getUserId());
            if (userInfo.getAdminFlag()==0) {
                realDeleteDictionary = false;
            }
        }

        //删除字典
        if (realDeleteDictionary) {
            //判断是否可以删除
            PageHelper.startPage(1, 1, false);
            List<Words> wordsList = wordsMapper.selectByDictionaryId(request.getDictionaryId());
            Assert.isTrue(wordsList.isEmpty(), "该字典已有单词存在, 不能删除");

            dictionaryMapper.deleteByPrimaryKey(request.getDictionaryId());
        }

        //删除用户和字典的绑定关系
        userDictionaryMapper.deleteByUserAndDictionary(request.getUserId(), request.getDictionaryId());

        return null;
    }
}
