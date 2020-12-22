package org.noodle.bean.dictionary;

import org.noodle.beans.NoodleRequest;

/**
 * 字典删除服务
 * @author wanghy
 */
public class DictionaryDeleteRequest extends NoodleRequest {
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
