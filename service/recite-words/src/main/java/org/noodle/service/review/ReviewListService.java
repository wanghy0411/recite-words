package org.noodle.service.review;

import org.noodle.bean.review.ReviewListRequest;
import org.noodle.beans.NoodleException;
import org.noodle.orm.mapper.ReviewMapper;
import org.noodle.orm.model.Review;
import org.noodle.service.NoodlePostService;
import org.springframework.stereotype.Service;

import javax.annotation.Resource;
import java.util.List;

/**
 * 个人复习记录查询服务
 * @author wanghy
 */
@Service("review.list")
public class ReviewListService implements NoodlePostService<ReviewListRequest, List<Review>> {
    @Resource
    private ReviewMapper reviewMapper;

    @Override
    public Class<ReviewListRequest> getRequestClass() {
        return ReviewListRequest.class;
    }

    @Override
    public List<Review> execute(ReviewListRequest request) throws NoodleException {
        long startTime;
        if (request.getStartTimestamp()==null) {
            startTime = System.currentTimeMillis() - 30L * 24 * 60 * 60 * 1000;
        }
        else {
            startTime = request.getStartTimestamp();
        }
        return reviewMapper.selectByUserId(request.getUserId(), startTime);
    }
}
