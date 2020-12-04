package org.noodle.orm.mapper;

import java.util.List;
import org.noodle.orm.model.Recite;

public interface ReciteMapper {
    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table recite
     *
     * @mbg.generated
     */
    int deleteByPrimaryKey(Long id);

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table recite
     *
     * @mbg.generated
     */
    int insert(Recite record);

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table recite
     *
     * @mbg.generated
     */
    Recite selectByPrimaryKey(Long id);

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table recite
     *
     * @mbg.generated
     */
    List<Recite> selectAll();

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table recite
     *
     * @mbg.generated
     */
    int updateByPrimaryKey(Recite record);
}