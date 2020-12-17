package org.noodle.service.dictionary;

import junit.framework.TestCase;
import org.noodle.bean.dictionary.list.DictionaryListRequest;
import org.noodle.bean.dictionary.save.DictionarySaveRequest;
import org.noodle.beans.NoodleApiParam;
import org.noodle.beans.NoodleResponse;
import org.noodle.orm.model.Dictionary;
import org.noodle.util.json.JsonParser;
import org.springframework.web.client.RestTemplate;

public class DictionarySaveServiceTest extends TestCase {

    public void testExecute() {
        DictionarySaveRequest request = new DictionarySaveRequest();
        Dictionary dictionary = new Dictionary();
        dictionary.setId(127044917365031937L);
        dictionary.setName("百词记忆(初一)Unit-1");
        dictionary.setValidFlag("Y");
        dictionary.setPublicFlag("N");
        request.setDictionary(dictionary);

        NoodleApiParam noodleApiParam = new NoodleApiParam();
        noodleApiParam.setApiMethodName("dictionary.save");
        noodleApiParam.setUserId(126813427162360833L);
        noodleApiParam.setRequestData(request);

        RestTemplate restTemplate = new RestTemplate();
        NoodleResponse response = restTemplate.postForObject("http://127.0.0.1:30005/release/fy-recite-words/post", noodleApiParam, NoodleResponse.class);

        JsonParser parser = JsonParser.getSingleInstance();
        System.out.println(parser.fromBean(response, NoodleResponse.class));
    }
}