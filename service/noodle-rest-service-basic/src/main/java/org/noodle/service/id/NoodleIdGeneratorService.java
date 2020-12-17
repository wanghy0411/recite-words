package org.noodle.service.id;

import org.noodle.beans.NoodleException;
import org.noodle.beans.id.NoodleIdGeneratorRequest;
import org.noodle.service.NoodlePostService;
import org.noodle.util.id.SnowFlake;
import org.springframework.stereotype.Service;

import javax.annotation.Resource;
import java.util.ArrayList;
import java.util.List;

/**
 * 唯一id获取服务
 * @author wanghy
 */
@Service("id.generate")
public class NoodleIdGeneratorService implements NoodlePostService<NoodleIdGeneratorRequest, List<Long>> {
    @Resource
    private SnowFlake snowFlake;

    @Override
    public Class<NoodleIdGeneratorRequest> getRequestClass() {
        return NoodleIdGeneratorRequest.class;
    }

    @Override
    public List<Long> execute(NoodleIdGeneratorRequest request) throws NoodleException {
        int number = request.getNumber()==null || request.getNumber()<=0?1:request.getNumber();
        List<Long> resultIdList = new ArrayList<>();
        for (int i=0;i<number;i++) {
            resultIdList.add(snowFlake.nextId());
        }
        return resultIdList;
    }
}
