package org.noodle.service.exercise;

import org.noodle.bean.exercise.ExerciseListRequest;
import org.noodle.beans.NoodleException;
import org.noodle.orm.mapper.ExerciseMapper;
import org.noodle.orm.model.Exercise;
import org.noodle.service.NoodlePostService;
import org.springframework.stereotype.Service;

import javax.annotation.Resource;
import java.util.List;

/**
 * 个人测验记录查询服务
 * @author wanghy
 */
@Service("exercise.list")
public class ExerciseListService implements NoodlePostService<ExerciseListRequest, List<Exercise>> {
    @Resource
    private ExerciseMapper exerciseMapper;

    @Override
    public Class<ExerciseListRequest> getRequestClass() {
        return ExerciseListRequest.class;
    }

    @Override
    public List<Exercise> execute(ExerciseListRequest request) throws NoodleException {
        long startTime;
        if (request.getStartTimestamp()==null) {
            startTime = System.currentTimeMillis() - 6 * 365L * 24 * 60 * 60 * 1000;
        }
        else {
            startTime = request.getStartTimestamp();
        }
        return exerciseMapper.selectByUserId(request.getUserId(), startTime);
    }
}
