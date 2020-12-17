package org.noodle.bean.user.password;

import org.noodle.beans.NoodleRequest;

/**
 * 用户密码验证服务
 * @author wanghy
 */
public class UserPasswordCheckRequest extends NoodleRequest {
    /**
     * 用户id
     */
    private String nick;
    /**
     * 用户密码
     */
    private String password;

    public String getNick() {
        return nick;
    }

    public void setNick(String nick) {
        this.nick = nick;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }
}
