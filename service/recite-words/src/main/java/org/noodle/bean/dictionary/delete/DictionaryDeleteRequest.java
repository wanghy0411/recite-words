package org.noodle.bean.dictionary.delete;

import org.noodle.beans.NoodlePagedRequest;

/**
 * 字典删除服务
 * @author wanghy
 */
public class DictionaryDeleteRequest extends NoodlePagedRequest {
    /**
     * 待删除的字典id
     */
    private Long dictionaryId;

    public Long getDictionaryId() {
        return dictionaryId;
    }

    public void setDictionaryId(Long dictionaryId) {
        this.dictionaryId = dictionaryId;
    }
}
