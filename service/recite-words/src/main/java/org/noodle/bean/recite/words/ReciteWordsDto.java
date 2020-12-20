package org.noodle.bean.recite.words;

/**
 * 背诵记录中的单词
 * @author wanghy
 */
public class ReciteWordsDto {
    /**
     * 背诵单词记录id
     */
    private Long id;

    /**
     * 背诵reciteId
     */
    private Long reciteId;

    /**
     * 单词wordId
     */
    private Long wordsId;

    /**
     * 拼写
     */
    private String spelling;

    /**
     * 发音
     */
    private String pronunciation;

    /**
     * 释义
     */
    private String explanation;

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public Long getReciteId() {
        return reciteId;
    }

    public void setReciteId(Long reciteId) {
        this.reciteId = reciteId;
    }

    public Long getWordsId() {
        return wordsId;
    }

    public void setWordsId(Long wordsId) {
        this.wordsId = wordsId;
    }

    public String getSpelling() {
        return spelling;
    }

    public void setSpelling(String spelling) {
        this.spelling = spelling;
    }

    public String getPronunciation() {
        return pronunciation;
    }

    public void setPronunciation(String pronunciation) {
        this.pronunciation = pronunciation;
    }

    public String getExplanation() {
        return explanation;
    }

    public void setExplanation(String explanation) {
        this.explanation = explanation;
    }
}
