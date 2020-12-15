package org.noodle.service.user.info;

import junit.framework.TestCase;
import org.noodle.bean.user.info.UserInfoQueryRequest;
import org.noodle.beans.NoodleApiParam;
import org.noodle.beans.NoodleResponse;
import org.noodle.util.json.JsonParser;
import org.springframework.web.client.RestTemplate;

public class UserInfoQueryServiceTest extends TestCase {

    public void testExecute() {
        UserInfoQueryRequest request = new UserInfoQueryRequest();
        request.setNick("wangyx");

        NoodleApiParam noodleApiParam = new NoodleApiParam();
        noodleApiParam.setApiMethodName("user.info.query");
        noodleApiParam.setRequestData(request);

        RestTemplate restTemplate = new RestTemplate();
        NoodleResponse response = restTemplate.postForObject("http://127.0.0.1:30005/release/fy-recite-words/post", noodleApiParam, NoodleResponse.class);

        JsonParser parser = JsonParser.getSingleInstance();
        System.out.println(parser.fromBean(response, NoodleResponse.class));
    }
}