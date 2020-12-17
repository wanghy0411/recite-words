package org.noodle.service.dictionary;

import junit.framework.TestCase;
import org.noodle.bean.dictionary.list.DictionaryListRequest;
import org.noodle.beans.NoodleApiParam;
import org.noodle.beans.NoodleResponse;
import org.noodle.util.json.JsonParser;
import org.springframework.web.client.RestTemplate;

public class DictionaryListServiceTest extends TestCase {
    public void testExecute() {
        DictionaryListRequest request = new DictionaryListRequest();

        NoodleApiParam noodleApiParam = new NoodleApiParam();
        noodleApiParam.setApiMethodName("dictionary.list");
        noodleApiParam.setUserId(126813427162360833L);
        noodleApiParam.setRequestData(request);

        RestTemplate restTemplate = new RestTemplate();
        NoodleResponse response = restTemplate.postForObject("http://127.0.0.1:30005/release/fy-recite-words/post", noodleApiParam, NoodleResponse.class);

        JsonParser parser = JsonParser.getSingleInstance();
        System.out.println(parser.fromBean(response, NoodleResponse.class));
    }
}
