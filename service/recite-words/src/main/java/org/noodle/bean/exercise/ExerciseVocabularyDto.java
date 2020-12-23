package org.noodle.bean.exercise;

/**
 * 个人可测验词汇
 * @author wanghy
 */
public class ExerciseVocabularyDto {
    /**
     * 词汇id
     */
    private Long vocabularyId;

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

    public Long getVocabularyId() {
        return vocabularyId;
    }

    public void setVocabularyId(Long vocabularyId) {
        this.vocabularyId = vocabularyId;
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
