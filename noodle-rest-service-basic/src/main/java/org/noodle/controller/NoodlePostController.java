package org.noodle.controller;

import org.apache.logging.log4j.LogManager;
import org.apache.logging.log4j.Logger;
import org.apache.logging.log4j.Marker;
import org.apache.logging.log4j.MarkerManager;
import org.noodle.beans.NoodleException;
import org.noodle.beans.NoodleApiParam;
import org.noodle.beans.NoodleResponse;
import org.noodle.service.ApplicationContextAwareNoodle;
import org.noodle.service.NoodlePostService;
import org.noodle.util.id.SnowFlake;
import org.noodle.util.json.JsonParser;
import org.springframework.web.bind.annotation.*;

import javax.annotation.Resource;

/**
 * 基础post服务controller
 * @author wanghy
 */
@RestController
@RequestMapping("/")
public class NoodlePostController {
    private static final Logger logger = LogManager.getLogger(NoodlePostController.class.getName());
    private static final JsonParser parser = JsonParser.getSingleInstance();

    @Resource
    private SnowFlake snowFlake;

    /**
     * 基础controller
     * @param noodleApiParam 接口入参
     * @return T 接口返回值信息
     */
    @CrossOrigin
    @PostMapping("/post")
    public NoodleResponse queryMemberInfo(@RequestBody NoodleApiParam noodleApiParam) {
        String requestNo = noodleApiParam.getClientRequestNo()==null?"":noodleApiParam.getClientRequestNo();
        noodleApiParam.setServerRequestNo(snowFlake.nextId());
        Marker requestMarker = MarkerManager.getMarker(requestNo+":"+noodleApiParam.getServerRequestNo());

        NoodleResponse response = new NoodleResponse();
        response.setClientRequestNo(noodleApiParam.getClientRequestNo());
        response.setServerRequestNo(noodleApiParam.getServerRequestNo());

        try {
            if (logger.isInfoEnabled()) {
                logger.info(requestMarker, parser.fromBean(noodleApiParam, noodleApiParam.getClass()));
            }

            NoodlePostService service = ApplicationContextAwareNoodle.getBean(noodleApiParam.getApiMethodName());
            Object data = service.execute(noodleApiParam);
            response.setSuccess(true);
            response.setErrorCode("0");
            response.setData(data);
        }
        catch (NoodleException e){
            if (logger.isErrorEnabled()) {
                logger.error(requestMarker,e.getMessage(),e);
            }

            response.setSuccess(false);
            response.setErrorCode(e.getErrCode());
            response.setErrorMessage(e.getMessage());
        }
        catch (Exception e) {
            if (logger.isErrorEnabled()) {
                logger.error(requestMarker,e.getMessage(),e);
            }

            response.setSuccess(false);
            response.setErrorCode("-1");
            response.setErrorMessage(e.getMessage());
        }
        finally {
            if (logger.isInfoEnabled()) {
                logger.info(requestMarker, parser.fromBean(response, response.getClass()));
            }
        }
        return response;
    }
}