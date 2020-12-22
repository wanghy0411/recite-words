package org.noodle.bean.review;

import org.noodle.beans.NoodleRequest;

/**
 * 单词复习记录中的单词列表获取服务
 * @author wanghy
 */
public class ReviewWordsRequest extends NoodleRequest {
    /**
     * 复习记录
     */
    private Long reviewId;

    public Long getReviewId() {
        return reviewId;
    }

    public void setReviewId(Long reviewId) {
        this.reviewId = reviewId;
    }
}
