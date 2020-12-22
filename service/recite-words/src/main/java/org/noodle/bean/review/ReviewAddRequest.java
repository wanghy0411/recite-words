package org.noodle.bean.review;

import org.noodle.beans.NoodleRequest;

import java.util.List;

/**
 * 复习记录增加服务
 * @author wanghy
 */
public class ReviewAddRequest extends NoodleRequest {
    /**
     * 本次复习记录的id
     */
    private Long id;

    /**
     * 备注信息
     */
    private String comment;

    /**
     * 本次复习的词汇id列表
     */
    private List<Long> vocabularyIds;

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public String getComment() {
        return comment;
    }

    public void setComment(String comment) {
        this.comment = comment;
    }

    public List<Long> getVocabularyIds() {
        return vocabularyIds;
    }

    public void setVocabularyIds(List<Long> vocabularyIds) {
        this.vocabularyIds = vocabularyIds;
    }
}
