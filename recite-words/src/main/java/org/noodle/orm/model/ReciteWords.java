package org.noodle.orm.model;

public class ReciteWords {
    /**
     *
     * This field was generated by MyBatis Generator.
     * This field corresponds to the database column recite_words.id
     *
     * @mbg.generated
     */
    private Long id;

    /**
     *
     * This field was generated by MyBatis Generator.
     * This field corresponds to the database column recite_words.recite_id
     *
     * @mbg.generated
     */
    private Long reciteId;

    /**
     *
     * This field was generated by MyBatis Generator.
     * This field corresponds to the database column recite_words.words_id
     *
     * @mbg.generated
     */
    private Long wordsId;

    /**
     * This method was generated by MyBatis Generator.
     * This method returns the value of the database column recite_words.id
     *
     * @return the value of recite_words.id
     *
     * @mbg.generated
     */
    public Long getId() {
        return id;
    }

    /**
     * This method was generated by MyBatis Generator.
     * This method sets the value of the database column recite_words.id
     *
     * @param id the value for recite_words.id
     *
     * @mbg.generated
     */
    public void setId(Long id) {
        this.id = id;
    }

    /**
     * This method was generated by MyBatis Generator.
     * This method returns the value of the database column recite_words.recite_id
     *
     * @return the value of recite_words.recite_id
     *
     * @mbg.generated
     */
    public Long getReciteId() {
        return reciteId;
    }

    /**
     * This method was generated by MyBatis Generator.
     * This method sets the value of the database column recite_words.recite_id
     *
     * @param reciteId the value for recite_words.recite_id
     *
     * @mbg.generated
     */
    public void setReciteId(Long reciteId) {
        this.reciteId = reciteId;
    }

    /**
     * This method was generated by MyBatis Generator.
     * This method returns the value of the database column recite_words.words_id
     *
     * @return the value of recite_words.words_id
     *
     * @mbg.generated
     */
    public Long getWordsId() {
        return wordsId;
    }

    /**
     * This method was generated by MyBatis Generator.
     * This method sets the value of the database column recite_words.words_id
     *
     * @param wordsId the value for recite_words.words_id
     *
     * @mbg.generated
     */
    public void setWordsId(Long wordsId) {
        this.wordsId = wordsId;
    }
}