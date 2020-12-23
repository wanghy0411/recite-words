package org.noodle.bean.exercise;

/**
 * 测验记录中的单词
 * @author wanghy
 */
public class ExerciseWordsDto {
    /**
     * 背诵单词记录id
     */
    private Long id;

    /**
     * 复习reviewId
     */
    private Long exerciseId;

    /**
     * 行号
     */
    private Integer lineNumber;

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

    /**
     * 练习对错(1正确0错误)
     */
    private Integer correct;

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public Long getExerciseId() {
        return exerciseId;
    }

    public void setExerciseId(Long exerciseId) {
        this.exerciseId = exerciseId;
    }

    public Integer getLineNumber() {
        return lineNumber;
    }

    public void setLineNumber(Integer lineNumber) {
        this.lineNumber = lineNumber;
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

    public Integer getCorrect() {
        return correct;
    }

    public void setCorrect(Integer correct) {
        this.correct = correct;
    }
}
