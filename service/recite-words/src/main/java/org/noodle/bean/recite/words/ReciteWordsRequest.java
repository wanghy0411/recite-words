package org.noodle.bean.recite.words;

import org.noodle.beans.NoodleRequest;

/**
 * 单词背诵记录中的单词列表获取服务
 * @author wanghy
 */
public class ReciteWordsRequest extends NoodleRequest {
    /**
     * 背诵记录
     */
    private Long reciteId;

    public Long getReciteId() {
        return reciteId;
    }

    public void setReciteId(Long reciteId) {
        this.reciteId = reciteId;
    }
}
