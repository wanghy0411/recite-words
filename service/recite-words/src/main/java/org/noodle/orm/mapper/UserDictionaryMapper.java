package org.noodle.orm.mapper;

import java.util.List;

import org.apache.ibatis.annotations.Param;
import org.noodle.orm.model.UserDictionary;

public interface UserDictionaryMapper {
    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table user_dictionary
     *
     * @mbg.generated
     */
    int deleteByPrimaryKey(Long id);

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table user_dictionary
     *
     * @mbg.generated
     */
    int insert(UserDictionary record);

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table user_dictionary
     *
     * @mbg.generated
     */
    UserDictionary selectByPrimaryKey(Long id);

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table user_dictionary
     *
     * @mbg.generated
     */
    List<UserDictionary> selectAll();

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table user_dictionary
     *
     * @mbg.generated
     */
    int updateByPrimaryKey(UserDictionary record);

    /*--------------------------------------------------------*/

    /**
     * 根据用户和字典查
     * @param userId 用户id
     * @param dictionaryId 字典id
     * @return 用户和字典对应关系
     */
    UserDictionary selectByUserAndDictionary(@Param("userId") Long userId, @Param("dictionaryId") Long dictionaryId);

    /**
     * 根据用户和字典删除
     * @param userId 用户id
     * @param dictionaryId 字典id
     * @return 影响的行数
     */
    int deleteByUserAndDictionary(@Param("userId") Long userId, @Param("dictionaryId") Long dictionaryId);
}