package org.noodle.beans;

/**
 * Noodle接口调用入参
 * @author wanghy
 */
public class NoodleApiParam {
    /**
     * 调用端传入的唯一标识符
     */
    protected String clientRequestNo;
    /**
     * 服务端赋予的唯一标识符
     */
    protected Long serverRequestNo;
    /**
     * 调用的api接口服务方法名
     */
    protected String apiMethodName;
    /**
     * 调用服务的版本号
     */
    protected Integer apiVersion;
    /**
     * 接口调用人员
     */
    protected String operatorId;
    /**
     * 客户端时间戳
     */
    protected Long timestamp;
    /**
     * 传入的数据信息
     */
    protected Object data;

    public String getClientRequestNo() {
        return clientRequestNo;
    }

    public void setClientRequestNo(String clientRequestNo) {
        this.clientRequestNo = clientRequestNo;
    }

    public Long getServerRequestNo() {
        return serverRequestNo;
    }

    public void setServerRequestNo(Long serverRequestNo) {
        this.serverRequestNo = serverRequestNo;
    }

    public String getApiMethodName() {
        return apiMethodName;
    }

    public void setApiMethodName(String apiMethodName) {
        this.apiMethodName = apiMethodName;
    }

    public Integer getApiVersion() {
        return apiVersion;
    }

    public void setApiVersion(Integer apiVersion) {
        this.apiVersion = apiVersion;
    }

    public String getOperatorId() {
        return operatorId;
    }

    public void setOperatorId(String operatorId) {
        this.operatorId = operatorId;
    }

    public Long getTimestamp() {
        return timestamp;
    }

    public void setTimestamp(Long timestamp) {
        this.timestamp = timestamp;
    }

    public Object getData() {
        return data;
    }

    public void setData(Object data) {
        this.data = data;
    }
}
