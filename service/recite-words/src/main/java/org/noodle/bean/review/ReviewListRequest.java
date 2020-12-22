package org.noodle.bean.review;

import org.noodle.beans.NoodleRequest;

/**
 * 个人指定时间后的复习记录列表获取服务
 * @author wanghy
 */
public class ReviewListRequest extends NoodleRequest {
    /**
     * 开始时间, 不输入缺省取30日内的记录
     */
    private Long startTimestamp;

    public Long getStartTimestamp() {
        return startTimestamp;
    }

    public void setStartTimestamp(Long startTimestamp) {
        this.startTimestamp = startTimestamp;
    }
}
