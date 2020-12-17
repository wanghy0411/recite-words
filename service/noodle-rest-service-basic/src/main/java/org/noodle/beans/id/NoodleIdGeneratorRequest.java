package org.noodle.beans.id;

import org.noodle.beans.NoodleRequest;

/**
 * id获取服务
 * @author wanghy
 */
public class NoodleIdGeneratorRequest extends NoodleRequest {
    /**
     * 需要生成的id个数, 缺省为1个
     */
    private Integer number;

    public Integer getNumber() {
        return number;
    }

    public void setNumber(Integer number) {
        this.number = number;
    }
}
