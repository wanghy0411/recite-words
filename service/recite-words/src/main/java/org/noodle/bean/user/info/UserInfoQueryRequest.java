package org.noodle.bean.user.info;


import org.noodle.beans.NoodleRequest;

/**
 * 用户查询服务
 * @author wanghy
 */
public class UserInfoQueryRequest extends NoodleRequest {
    /**
     * 用户昵称
     */
    private String nick;

    public String getNick() {
        return nick;
    }

    public void setNick(String nick) {
        this.nick = nick;
    }
}
