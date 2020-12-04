package org.noodle.orm.mapper;

import java.util.List;
import org.noodle.orm.model.ReciteWords;

public interface ReciteWordsMapper {
    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table recite_words
     *
     * @mbg.generated
     */
    int deleteByPrimaryKey(Long id);

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table recite_words
     *
     * @mbg.generated
     */
    int insert(ReciteWords record);

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table recite_words
     *
     * @mbg.generated
     */
    ReciteWords selectByPrimaryKey(Long id);

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table recite_words
     *
     * @mbg.generated
     */
    List<ReciteWords> selectAll();

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table recite_words
     *
     * @mbg.generated
     */
    int updateByPrimaryKey(ReciteWords record);
}