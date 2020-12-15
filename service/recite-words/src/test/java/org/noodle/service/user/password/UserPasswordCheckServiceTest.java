package org.noodle.service.user.password;

import junit.framework.TestCase;
import org.noodle.bean.user.password.UserPasswordCheckRequest;
import org.noodle.beans.NoodleApiParam;
import org.noodle.beans.NoodleResponse;
import org.noodle.util.json.JsonParser;
import org.springframework.web.client.RestTemplate;

public class UserPasswordCheckServiceTest extends TestCase {

    public void testExecute() {
        UserPasswordCheckRequest request = new UserPasswordCheckRequest();
        request.setUserId(528350233536979752L);
        request.setPassword("test");

        NoodleApiParam noodleApiParam = new NoodleApiParam();
        noodleApiParam.setApiMethodName("user.password.check");
        noodleApiParam.setRequestData(request);

        RestTemplate restTemplate = new RestTemplate();
        NoodleResponse response = restTemplate.postForObject("http://127.0.0.1:30005/release/fy-recite-words/post", noodleApiParam, NoodleResponse.class);

        JsonParser parser = JsonParser.getSingleInstance();
        System.out.println(parser.fromBean(response, NoodleResponse.class));
    }
}