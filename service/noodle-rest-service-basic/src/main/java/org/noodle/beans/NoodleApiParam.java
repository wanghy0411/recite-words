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
