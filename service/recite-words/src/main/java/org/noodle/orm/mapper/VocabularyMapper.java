package org.noodle.orm.mapper;

import java.util.List;

import org.apache.ibatis.annotations.Param;
import org.noodle.orm.model.Vocabulary;

public interface VocabularyMapper {
    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table vocabulary
     *
     * @mbg.generated
     */
    int deleteByPrimaryKey(Long id);

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table vocabulary
     *
     * @mbg.generated
     */
    int insert(Vocabulary record);

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table vocabulary
     *
     * @mbg.generated
     */
    Vocabulary selectByPrimaryKey(Long id);

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table vocabulary
     *
     * @mbg.generated
     */
    List<Vocabulary> selectAll();

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table vocabulary
     *
     * @mbg.generated
     */
    int updateByPrimaryKey(Vocabulary record);

    /*----------------------------------------------------*/

    /**
     * 根据单词id查, 一般用于判断是否存在
     * @param wordsId 单词id
     */
    List<Vocabulary> selectByWordsId(Long wordsId);

    /**
     * 根据用户查应复习词汇
     * @param userId 用户id
     * @param reviewTime 复习时间
     */
    List<Vocabulary> selectNeedReviewByUser(@Param("userId") Long userId, @Param("reviewTime") Long reviewTime);
}