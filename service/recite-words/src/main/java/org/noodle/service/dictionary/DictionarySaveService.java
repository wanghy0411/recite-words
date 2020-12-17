package org.noodle.service.dictionary;

import org.noodle.bean.dictionary.save.DictionarySaveRequest;
import org.noodle.beans.NoodleException;
import org.noodle.orm.mapper.DictionaryMapper;
import org.noodle.orm.mapper.UserDictionaryMapper;
import org.noodle.orm.mapper.UserInfoMapper;
import org.noodle.orm.model.UserDictionary;
import org.noodle.orm.model.UserInfo;
import org.noodle.service.NoodlePostService;
import org.noodle.util.id.SnowFlake;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Propagation;
import org.springframework.transaction.annotation.Transactional;
import org.springframework.util.Assert;
import org.springframework.util.StringUtils;

import javax.annotation.Resource;

/**
 * 字典保存服务
 * @author wanghy
 */
@Service("dictionary.save")
public class DictionarySaveService implements NoodlePostService<DictionarySaveRequest, Object> {
    @Resource
    private DictionaryMapper dictionaryMapper;

    @Resource
    private UserDictionaryMapper userDictionaryMapper;

    @Resource
    private UserInfoMapper userInfoMapper;

    @Resource
    private SnowFlake snowFlake;

    @Override
    public Class<DictionarySaveRequest> getRequestClass() {
        return DictionarySaveRequest.class;
    }

    @Transactional(propagation = Propagation.REQUIRED, rollbackFor = {Exception.class,NoodleException.class,RuntimeException.class})
    @Override
    public Object execute(DictionarySaveRequest request) throws NoodleException {
        Assert.notNull(request.getDictionary(), "传入的字典对象不能为空");
        Assert.isTrue(request.getDictionary().getId()>0, "请传入有效的id");
        Assert.isTrue(StringUtils.hasText(request.getDictionary().getName()), "字典名称不能为空");
        Assert.isTrue(StringUtils.hasText(request.getDictionary().getValidFlag()), "有效标志不能为空");
        Assert.isTrue("YN".contains(request.getDictionary().getValidFlag()), "有效标志只能为Y/N");
        Assert.isTrue(StringUtils.hasText(request.getDictionary().getPublicFlag()), "公用标志不能为空");
        Assert.isTrue("YN".contains(request.getDictionary().getPublicFlag()), "公用标志只能为Y/N");
        if ("Y".equals(request.getDictionary().getPublicFlag())) {
            UserInfo userInfo = userInfoMapper.selectByPrimaryKey(request.getUserId());
            if (userInfo.getAdminFlag()==0) {
                throw new IllegalArgumentException("只有管理员才可设置公用字典");
            }
        }

        int updateCount = dictionaryMapper.updateByPrimaryKey(request.getDictionary());
        if (updateCount==0) {
            dictionaryMapper.insert(request.getDictionary());

            //新字典则保存用户选定字典表
            UserDictionary userDictionary = new UserDictionary();
            userDictionary.setId(snowFlake.nextId());
            userDictionary.setUserId(request.getUserId());
            userDictionary.setDictionaryId(request.getDictionary().getId());
            userDictionaryMapper.insert(userDictionary);
        }
        return null;
    }
}
