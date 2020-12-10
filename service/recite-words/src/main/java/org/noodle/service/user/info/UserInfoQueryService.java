package org.noodle.service.user.info;

import org.noodle.bean.user.info.UserInfoQueryRequest;
import org.noodle.beans.NoodleException;
import org.noodle.beans.NoodleApiParam;
import org.noodle.orm.mapper.UserInfoMapper;
import org.noodle.orm.model.UserInfo;
import org.noodle.service.NoodlePostService;
import org.noodle.util.convertor.Object2JavaBean;
import org.springframework.stereotype.Service;

import javax.annotation.Resource;

/**
 * 用户查询服务（根据昵称查用户信息）
 * @author wanghy
 */
@Service("user.info.query")
public class UserInfoQueryService implements NoodlePostService {
    @Resource
    private UserInfoMapper userInfoMapper;

    @Override
    public UserInfo execute(NoodleApiParam noodleApiParam) throws NoodleException {
        UserInfoQueryRequest request = Object2JavaBean.toBean(noodleApiParam.getData(), UserInfoQueryRequest.class);
        return userInfoMapper.selectByNick(request.getNick());
    }
}
