package org.noodle.bean.recite.add;

import org.noodle.beans.NoodleRequest;


/**
 * 背诵记录增加服务
 * @author wanghy
 */
public class ReciteAddRequest extends NoodleRequest {
    /**
     * 本次背诵记录的id
     */
    private Long id;

    /**
     * 备注信息
     */
    private String comment;

    /**
     * 记忆曲线(第1次复习时间, 天数, 缺省为1)
     */
    private Integer schedule1;

    /**
     * 记忆曲线(第2次复习时间, 天数, 缺省为7)
     */
    private Integer schedule2;

    /**
     * 记忆曲线(第3次复习时间, 天数, 缺省为30)
     */
    private Integer schedule3;

    /**
     * 记忆曲线(第4次复习时间, 天数, 缺省为90)
     */
    private Integer schedule4;

    /**
     * 计划背诵的单词数量, 缺省为20个
     */
    private Integer wordsNumber;

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public String getComment() {
        return comment;
    }

    public void setComment(String comment) {
        this.comment = comment;
    }

    public Integer getSchedule1() {
        return schedule1;
    }

    public void setSchedule1(Integer schedule1) {
        this.schedule1 = schedule1;
    }

    public Integer getSchedule2() {
        return schedule2;
    }

    public void setSchedule2(Integer schedule2) {
        this.schedule2 = schedule2;
    }

    public Integer getSchedule3() {
        return schedule3;
    }

    public void setSchedule3(Integer schedule3) {
        this.schedule3 = schedule3;
    }

    public Integer getSchedule4() {
        return schedule4;
    }

    public void setSchedule4(Integer schedule4) {
        this.schedule4 = schedule4;
    }

    public Integer getWordsNumber() {
        return wordsNumber;
    }

    public void setWordsNumber(Integer wordsNumber) {
        this.wordsNumber = wordsNumber;
    }
}
