package org.noodle.bean.words.list;

import org.noodle.beans.NoodlePagedRequest;

/**
 * 单词列表查询服务
 * @author wanghy
 */
public class WordsListRequest extends NoodlePagedRequest {
    private Long dictionaryId;

    public Long getDictionaryId() {
        return dictionaryId;
    }

    public void setDictionaryId(Long dictionaryId) {
        this.dictionaryId = dictionaryId;
    }
}
