package org.noodle.beans;


import java.io.Serializable;

/**
 * Noodle接口调用返回值
 * @author wanghy
 */
public class NoodleResponse implements Serializable {
    private static final long serialVersionUID = 3250666880483664876L;
    /**
     * 调用端传入的唯一标识符
     */
    protected String clientRequestNo;
    /**
     * 服务端赋予的唯一标识符
     */
    protected Long serverRequestNo;
    protected Boolean success;
    protected String errorMessage;
    protected String errorCode;

    public Object data;

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

    public Boolean getSuccess() {
        return success;
    }

    public void setSuccess(Boolean success) {
        this.success = success;
    }

    public String getErrorMessage() {
        return errorMessage;
    }

    public void setErrorMessage(String errorMessage) {
        this.errorMessage = errorMessage;
    }

    public String getErrorCode() {
        return errorCode;
    }

    public void setErrorCode(String errorCode) {
        this.errorCode = errorCode;
    }

    public Object getData() {
        return data;
    }

    public void setData(Object data) {
        this.data = data;
    }
}
