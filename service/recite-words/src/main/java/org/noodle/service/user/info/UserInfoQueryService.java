package org.noodle.service.user.info;

import org.noodle.bean.user.info.UserInfoQueryRequest;
import org.noodle.beans.NoodleException;
import org.noodle.orm.mapper.UserInfoMapper;
import org.noodle.orm.model.UserInfo;
import org.noodle.service.NoodlePostService;
import org.springframework.stereotype.Service;

import javax.annotation.Resource;

/**
 * 用户查询服务（根据昵称查用户信息）
 * @author wanghy
 */
@Service("user.info.query")
public class UserInfoQueryService implements NoodlePostService<UserInfoQueryRequest, UserInfo> {
    @Resource
    private UserInfoMapper userInfoMapper;

    @Override
    public Class<UserInfoQueryRequest> getRequestClass() {
        return UserInfoQueryRequest.class;
    }

    @Override
    public UserInfo execute(UserInfoQueryRequest request) throws NoodleException {
        return userInfoMapper.selectByNick(request.getNick());
    }
}
