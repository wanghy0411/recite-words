package org.noodle.beans;

/**
 * noodle服务框架request基类
 * @author wanghy
 */
public class NoodleRequest {
    /**
     * 调用端传入的唯一标识符
     */
    protected String clientRequestNo;
    /**
     * 服务端赋予的唯一标识符
     */
    protected long serverRequestNo;
    /**
     * 调用服务的版本号
     */
    protected String apiVersion;
    /**
     * 接口调用人员
     */
    protected Long userId;

    public String getClientRequestNo() {
        return clientRequestNo;
    }

    public void setClientRequestNo(String clientRequestNo) {
        this.clientRequestNo = clientRequestNo;
    }

    public long getServerRequestNo() {
        return serverRequestNo;
    }

    public void setServerRequestNo(long serverRequestNo) {
        this.serverRequestNo = serverRequestNo;
    }

    public String getApiVersion() {
        return apiVersion;
    }

    public void setApiVersion(String apiVersion) {
        this.apiVersion = apiVersion;
    }

    public Long getUserId() {
        return userId;
    }

    public void setUserId(Long userId) {
        this.userId = userId;
    }
}
