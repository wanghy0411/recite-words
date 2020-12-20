package org.noodle.service.recite;

import junit.framework.TestCase;
import org.noodle.bean.recite.add.ReciteAddRequest;
import org.noodle.beans.NoodleApiParam;
import org.noodle.beans.NoodleResponse;
import org.noodle.util.json.JsonParser;
import org.springframework.web.client.RestTemplate;

public class ReciteAddServiceTest extends TestCase {

    public void testExecute() {
        ReciteAddRequest request = new ReciteAddRequest();
        request.setId(128563786743505921L);
        request.setWordsNumber(15);
        request.setComment("test");
        request.setSchedule1(1);
        request.setSchedule2(7);
        request.setSchedule3(30);
        request.setSchedule4(90);

        NoodleApiParam noodleApiParam = new NoodleApiParam();
        noodleApiParam.setApiMethodName("recite.add");
        noodleApiParam.setUserId(126813427162360833L);
        noodleApiParam.setRequestData(request);

        RestTemplate restTemplate = new RestTemplate();
        NoodleResponse response = restTemplate.postForObject("http://127.0.0.1:30005/test" +
                "/fy-recite-words/post", noodleApiParam, NoodleResponse.class);

        JsonParser parser = JsonParser.getSingleInstance();
        System.out.println(parser.fromBean(response, NoodleResponse.class));
    }
}