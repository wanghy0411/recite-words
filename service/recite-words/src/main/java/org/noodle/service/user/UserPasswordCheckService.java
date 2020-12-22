package org.noodle.service.user;

import org.noodle.bean.user.UserPasswordCheckRequest;
import org.noodle.beans.NoodleException;
import org.noodle.orm.mapper.UserInfoMapper;
import org.noodle.orm.mapper.UserPasswordMapper;
import org.noodle.orm.model.UserInfo;
import org.noodle.orm.model.UserPassword;
import org.noodle.service.NoodlePostService;
import org.springframework.stereotype.Service;
import org.springframework.util.Assert;
import org.springframework.util.StringUtils;

import javax.annotation.Resource;

/**
 * 用户密码验证服务
 * @author wanghy
 */
@Service("user.password.check")
public class UserPasswordCheckService implements NoodlePostService<UserPasswordCheckRequest, Long> {
    @Resource
    private UserPasswordMapper userPasswordMapper;

    @Resource
    private UserInfoMapper userInfoMapper;

    @Override
    public Class<UserPasswordCheckRequest> getRequestClass() {
        return UserPasswordCheckRequest.class;
    }

    @Override
    public Long execute(UserPasswordCheckRequest request) throws NoodleException {
        Assert.isTrue(StringUtils.hasText(request.getNick()), "用户不能为空");
        Assert.isTrue(StringUtils.hasText(request.getPassword()), "密码不能为空");
        UserInfo userInfo = userInfoMapper.selectByNick(request.getNick());
        Assert.notNull(userInfo, "用户或密码输入错误");

        UserPassword userPassword = userPasswordMapper.selectByPrimaryKey(userInfo.getId());
        Assert.notNull(userPassword, "用户"+request.getNick()+"无密码记录信息");
        Assert.notNull(userPassword, "用户"+request.getNick()+"未设置密码");

        Assert.isTrue(request.getPassword().equals(userPassword.getPassword()), "输入的密码不正确");

        return userInfo.getId();
    }
}
