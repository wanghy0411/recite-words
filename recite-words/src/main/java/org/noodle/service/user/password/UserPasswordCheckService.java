package org.noodle.service.user.password;

import org.noodle.bean.user.password.UserPasswordCheckRequest;
import org.noodle.beans.NoodleApiParam;
import org.noodle.orm.mapper.UserPasswordMapper;
import org.noodle.orm.model.UserPassword;
import org.noodle.service.NoodlePostService;
import org.noodle.util.convertor.Object2JavaBean;
import org.springframework.stereotype.Service;
import org.springframework.util.Assert;

import javax.annotation.Resource;

/**
 * 用户密码验证服务
 * @author wanghy
 */
@Service("user.password.check")
public class UserPasswordCheckService implements NoodlePostService {
    @Resource
    private UserPasswordMapper userPasswordMapper;

    @Override
    public Object execute(NoodleApiParam noodleApiParam) {
        UserPasswordCheckRequest request = Object2JavaBean.toBean(noodleApiParam.getData(), UserPasswordCheckRequest.class);
        Assert.notNull(request.getUserId(), "用户id不能为空");
        Assert.notNull(request.getPassword(), "密码不能为空");
        Assert.hasLength(request.getPassword(), "密码不能为空");

        UserPassword userPassword = userPasswordMapper.selectByPrimaryKey(request.getUserId());
        Assert.notNull(userPassword, "用户"+request.getUserId()+"无密码记录信息");
        Assert.notNull(userPassword, "用户"+request.getUserId()+"未设置密码");

        Assert.isTrue(request.getPassword().equals(userPassword.getPassword()), "输入的密码不正确");

        return null;
    }
}