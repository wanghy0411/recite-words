package org.noodle.controller;

import cn.hutool.core.convert.Convert;
import cn.hutool.core.exceptions.ExceptionUtil;
import org.apache.logging.log4j.LogManager;
import org.apache.logging.log4j.Logger;
import org.apache.logging.log4j.Marker;
import org.apache.logging.log4j.MarkerManager;
import org.noodle.beans.NoodleApiParam;
import org.noodle.beans.NoodleException;
import org.noodle.beans.NoodleRequest;
import org.noodle.beans.NoodleResponse;
import org.noodle.service.ApplicationContextAwareNoodle;
import org.noodle.service.NoodlePostService;
import org.noodle.util.id.SnowFlake;
import org.noodle.util.json.JsonParser;
import org.springframework.util.Assert;
import org.springframework.util.StringUtils;
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
    @SuppressWarnings({"rawtypes","uncheck"})
    @CrossOrigin
    @PostMapping("/post")
    public NoodleResponse post(@RequestBody NoodleApiParam noodleApiParam) {


        NoodleResponse response = new NoodleResponse();
        String clientRequestNo = null;
        Long serverRequestNo = null;
        Marker requestMarker = null;
        try {
            //执行开始时间
            noodleApiParam.setStartTime(System.currentTimeMillis());

            //基本参数验证
            Assert.isTrue(StringUtils.hasText(noodleApiParam.getApiMethodName()), "没有传入接口方法名");
            Assert.notNull(noodleApiParam.getRequestData(), "没有传入调用串");

            NoodlePostService service = ApplicationContextAwareNoodle.getBean(noodleApiParam.getApiMethodName());

//            NoodleRequest request = (NoodleRequest) Object2JavaBean.toBean(noodleApiParam.getRequestData(), service.getRequestClass());
            NoodleRequest request = (NoodleRequest) Convert.convert(service.getRequestClass(), noodleApiParam.getRequestData());
            clientRequestNo = request.getClientRequestNo();
            serverRequestNo = snowFlake.nextId();

            //日志信息
            requestMarker = MarkerManager.getMarker(clientRequestNo+":"+serverRequestNo);
            if (logger.isInfoEnabled()) {
                logger.info(requestMarker, "calling "+parser.fromBean(noodleApiParam, noodleApiParam.getClass()));
            }

            //执行方法
            Object responseData = service.execute(request);
            response.setSuccess(true);
            response.setErrorCode("0");
            response.setData(responseData);
        }
        catch (IllegalArgumentException e){
            if (logger.isInfoEnabled()) {
                logger.info(requestMarker,e.getMessage());
            }

            response.setSuccess(false);
            response.setErrorCode("-2");
            response.setErrorMessage(e.getMessage());
        }
        catch (NoodleException e){
            if (logger.isInfoEnabled()) {
                logger.info(requestMarker,e.getMessage());
            }

            response.setSuccess(false);
            response.setErrorCode(e.getErrCode());
            response.setErrorMessage(e.getMessage());
        }
        catch (Exception e) {
            e.printStackTrace();

            if (logger.isErrorEnabled()) {
                logger.error(requestMarker,e.getMessage(),e);
            }

            response.setSuccess(false);
            response.setErrorCode("-1");
            response.setErrorMessage(e.getMessage());
            noodleApiParam.setExceptionStack(ExceptionUtil.stacktraceToString(e));
        }
        finally {
            noodleApiParam.setEndTime(System.currentTimeMillis());
            response.setClientRequestNo(clientRequestNo);
            response.setServerRequestNo(serverRequestNo);
        }

        noodleApiParam.setResponseData(response);
        if (logger.isInfoEnabled()) {
            logger.info(requestMarker, parser.fromBean(noodleApiParam, noodleApiParam.getClass()));
        }
        return response;
    }
}