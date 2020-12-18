package org.noodle.bean.dictionary.save;

import org.noodle.beans.NoodlePagedRequest;
import org.noodle.beans.NoodleRequest;
import org.noodle.orm.model.Dictionary;

/**
 * 字典保存服务
 * @author wanghy
 */
public class DictionarySaveRequest extends NoodleRequest {
    /**
     * 字典
     */
    private Dictionary dictionary;

    public Dictionary getDictionary() {
        return dictionary;
    }

    public void setDictionary(Dictionary dictionary) {
        this.dictionary = dictionary;
    }
}
