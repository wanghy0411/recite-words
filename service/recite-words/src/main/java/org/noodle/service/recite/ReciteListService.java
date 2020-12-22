package org.noodle.service.recite;

import org.noodle.bean.recite.ReciteListRequest;
import org.noodle.beans.NoodleException;
import org.noodle.orm.mapper.ReciteMapper;
import org.noodle.orm.model.Recite;
import org.noodle.service.NoodlePostService;
import org.springframework.stereotype.Service;

import javax.annotation.Resource;
import java.util.List;

/**
 * 个人背诵记录查询服务
 * @author wanghy
 */
@Service("recite.list")
public class ReciteListService implements NoodlePostService<ReciteListRequest, List<Recite>> {
    @Resource
    private ReciteMapper reciteMapper;

    @Override
    public Class<ReciteListRequest> getRequestClass() {
        return ReciteListRequest.class;
    }

    @Override
    public List<Recite> execute(ReciteListRequest request) throws NoodleException {
        long startTime;
        if (request.getStartTimestamp()==null) {
            startTime = System.currentTimeMillis() - 30L * 24 * 60 * 60 * 1000;
        }
        else {
            startTime = request.getStartTimestamp();
        }
        return reciteMapper.selectByUserId(request.getUserId(), startTime);
    }
}
