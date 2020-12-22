package org.noodle.bean.recite;

import org.noodle.beans.NoodleRequest;

/**
 * 个人指定时间后的背诵记录列表获取服务
 * @author wanghy
 */
public class ReciteListRequest extends NoodleRequest {
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
