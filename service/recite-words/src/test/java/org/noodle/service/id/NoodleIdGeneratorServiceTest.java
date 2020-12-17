package org.noodle.service.id;

import junit.framework.TestCase;
import org.noodle.beans.NoodleApiParam;
import org.noodle.beans.NoodleResponse;
import org.noodle.beans.id.NoodleIdGeneratorRequest;
import org.noodle.util.json.JsonParser;
import org.springframework.web.client.RestTemplate;

public class NoodleIdGeneratorServiceTest extends TestCase {
    public void testExecute() {
        NoodleIdGeneratorRequest request = new NoodleIdGeneratorRequest();
        request.setNumber(10);

        NoodleApiParam noodleApiParam = new NoodleApiParam();
        noodleApiParam.setApiMethodName("id.generate");
        noodleApiParam.setRequestData(request);

        RestTemplate restTemplate = new RestTemplate();
        NoodleResponse response = restTemplate.postForObject("http://127.0.0.1:30005/release/fy-recite-words/post", noodleApiParam, NoodleResponse.class);

        JsonParser parser = JsonParser.getSingleInstance();
        System.out.println(parser.fromBean(response, NoodleResponse.class));
    }
}
