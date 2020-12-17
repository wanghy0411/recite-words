package org.noodle.beans;

/**
 * noodle服务框架分页处理request基类
 * @author wanghy
 */
public class NoodlePagedRequest extends NoodleRequest{
    protected Integer pageSize;
    protected Integer pageNum;

    public Integer getPageSize() {
        return pageSize;
    }

    public void setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
    }

    public Integer getPageNum() {
        return pageNum;
    }

    public void setPageNum(Integer pageNum) {
        this.pageNum = pageNum;
    }
}
