package org.noodle.bean.user.password;

/**
 * 用户密码验证服务
 * @author wanghy
 */
public class UserPasswordCheckRequest {
    /**
     * 用户id
     */
    private Long userId;
    /**
     * 用户密码
     */
    private String password;

    public Long getUserId() {
        return userId;
    }

    public void setUserId(Long userId) {
        this.userId = userId;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }
}
