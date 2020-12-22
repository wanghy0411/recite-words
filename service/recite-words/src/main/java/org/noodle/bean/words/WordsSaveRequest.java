package org.noodle.bean.words;

import org.noodle.beans.NoodleRequest;
import org.noodle.orm.model.Words;

/**
 * 单词保存服务
 * @author wanghy
 */
public class WordsSaveRequest extends NoodleRequest {
    /**
     * 单词
     */
    private Words words;

    public Words getWords() {
        return words;
    }

    public void setWords(Words words) {
        this.words = words;
    }
}
