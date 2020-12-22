package org.noodle.bean.dictionary;

import org.noodle.beans.NoodleRequest;

/**
 * 用户选定使用字典服务
 * @author wanghy
 */
public class DictionarySelectRequest extends NoodleRequest {
    /**
     * 选定使用的字典id
     */
    private Long dictionaryId;

    public Long getDictionaryId() {
        return dictionaryId;
    }

    public void setDictionaryId(Long dictionaryId) {
        this.dictionaryId = dictionaryId;
    }
}
