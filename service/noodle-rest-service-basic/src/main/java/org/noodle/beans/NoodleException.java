package org.noodle.beans;

/**
 * Noodle内部异常信息
 * @author wanghy
 */
public class NoodleException extends RuntimeException {
    private static final long serialVersionUID = -2592030476404869023L;
    private String errCode;
    private String errMsg;

    public NoodleException(String errCode, String errMsg) {
        super(errCode + ":" + errMsg);
        this.errCode = errCode;
        this.errMsg = errMsg;
    }

    public String getErrCode() {
        return errCode;
    }

    public void setErrCode(String errCode) {
        this.errCode = errCode;
    }

    public String getErrMsg() {
        return errMsg;
    }

    public void setErrMsg(String errMsg) {
        this.errMsg = errMsg;
    }
}
