package org.noodle.bean.exercise;

import org.noodle.beans.NoodleRequest;

/**
 * 单词测验记录中的单词列表获取服务
 * @author wanghy
 */
public class ExerciseWordsRequest extends NoodleRequest {
    /**
     * 复习记录
     */
    private Long exerciseId;

    public Long getExerciseId() {
        return exerciseId;
    }

    public void setExerciseId(Long exerciseId) {
        this.exerciseId = exerciseId;
    }
}
