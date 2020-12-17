package org.noodle.beans;

/**
 * Noodle接口调用入参
 * @author wanghy
 */
public class NoodleApiParam {

    /**
     * 调用的api接口服务方法名
     */
    protected String apiMethodName;

    /**
     * 接口调用人员, 可以在gateway处加入token或cookie判断后统一写入
     * 如未加统一判断输入, 可先兼容前端输入
     */
    protected Long userId;

    /**
     * 客户端时间戳
     */
    protected Long timestamp;

    /**
     * 执行开始时间
     */
    protected Long startTime;

    /**
     * 执行结束时间
     */
    protected Long endTime;

    /**
     * 服务端赋予的唯一标识符
     */
    protected Long serverRequestNo;

    /**
     * 传入的数据信息
     */
    protected Object requestData;

    /**
     * 返回的数据信息
     */
    protected Object responseData;

    /**
     * 异常堆栈信息
     */
    protected String exceptionStack;

    public String getApiMethodName() {
        return apiMethodName;
    }

    public void setApiMethodName(String apiMethodName) {
        this.apiMethodName = apiMethodName;
    }

    public Long getUserId() {
        return userId;
    }

    public void setUserId(Long userId) {
        this.userId = userId;
    }

    public Long getTimestamp() {
        return timestamp;
    }

    public void setTimestamp(Long timestamp) {
        this.timestamp = timestamp;
    }

    public Long getStartTime() {
        return startTime;
    }

    public void setStartTime(Long startTime) {
        this.startTime = startTime;
    }

    public Long getEndTime() {
        return endTime;
    }

    public void setEndTime(Long endTime) {
        this.endTime = endTime;
    }

    public Long getServerRequestNo() {
        return serverRequestNo;
    }

    public void setServerRequestNo(Long serverRequestNo) {
        this.serverRequestNo = serverRequestNo;
    }

    public Object getRequestData() {
        return requestData;
    }

    public void setRequestData(Object requestData) {
        this.requestData = requestData;
    }

    public Object getResponseData() {
        return responseData;
    }

    public void setResponseData(Object responseData) {
        this.responseData = responseData;
    }

    public String getExceptionStack() {
        return exceptionStack;
    }

    public void setExceptionStack(String exceptionStack) {
        this.exceptionStack = exceptionStack;
    }
}
