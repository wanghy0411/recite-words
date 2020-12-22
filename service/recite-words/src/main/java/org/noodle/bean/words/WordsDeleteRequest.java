package org.noodle.bean.words;

import org.noodle.beans.NoodleRequest;

/**
 * 单词删除服务
 * @author wanghy
 */
public class WordsDeleteRequest extends NoodleRequest {
    /**
     * 单词id
     */
    private Long wordsId;

    public Long getWordsId() {
        return wordsId;
    }

    public void setWordsId(Long wordsId) {
        this.wordsId = wordsId;
    }
}
