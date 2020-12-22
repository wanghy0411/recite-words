package org.noodle.bean.dictionary;

import org.noodle.beans.NoodlePagedRequest;

/**
 * 公用字典搜索服务
 * @author wanghy
 */
public class DictionarySearchPublicRequest extends NoodlePagedRequest {
    /**
     * 字典名称搜索条件, 不用含%等符号
     */
    private String nameCondition;

    public String getNameCondition() {
        return nameCondition;
    }

    public void setNameCondition(String nameCondition) {
        this.nameCondition = nameCondition;
    }
}
