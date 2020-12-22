package org.noodle.bean.review;

/**
 * 复习记录中的单词
 * @author wanghy
 */
public class ReviewWordsDto {
    /**
     * 背诵单词记录id
     */
    private Long id;

    /**
     * 复习reviewId
     */
    private Long reviewId;

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

    public Long getReviewId() {
        return reviewId;
    }

    public void setReviewId(Long reviewId) {
        this.reviewId = reviewId;
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
