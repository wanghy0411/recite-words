package org.noodle.bean.exercise;

import org.noodle.beans.NoodleRequest;
import org.noodle.orm.model.ExerciseWords;

import java.util.List;

/**
 * 测验打分服务
 * @author wanghy
 */
public class ExerciseScoreRequest extends NoodleRequest {
    /**
     * 本次测验记录的id
     */
    private Long id;

    /**
     * 测验单词打分记录, 只需要传入id和correct即可
     */
    private List<ExerciseWords> exerciseWords;

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public List<ExerciseWords> getExerciseWords() {
        return exerciseWords;
    }

    public void setExerciseWords(List<ExerciseWords> exerciseWords) {
        this.exerciseWords = exerciseWords;
    }
}
