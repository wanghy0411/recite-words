package org.noodle.util.json;

import com.fasterxml.jackson.core.type.TypeReference;
import com.fasterxml.jackson.databind.DeserializationFeature;
import com.fasterxml.jackson.databind.ObjectMapper;

import java.io.IOException;

/**
 * Json和Bean转换工具, 为了保证性能, 使用饿汉式单例模式(线程安全), 只创建一次mapper
 * @author wanghy
 *
 */
public class JsonParser {
    private static final JsonParser jsonParser = new JsonParser();
    private final ObjectMapper mapper = new ObjectMapper();

    public static JsonParser getSingleInstance()
    {
        return jsonParser;
    }

    private JsonParser()
    {
        mapper.configure(DeserializationFeature.FAIL_ON_UNKNOWN_PROPERTIES, false);
    }

    public <T> T toBean(String paramString, Class<T> convertClass) {
        try {
            return mapper.readValue(paramString, convertClass);
        }
        catch (IOException e) {
            throw new RuntimeException(e.getCause());
        }
    }

    public <T> T toBean(String paramString, TypeReference<T> typeReference) {
        try {
            return mapper.readValue(paramString, typeReference);
        }
        catch (IOException e) {
            throw new RuntimeException(e.getCause());
        }
    }

    public <T> String fromBean(Object objectBean, Class<T> convertClass) {
        return fromBean(objectBean, convertClass, "utf-8");
    }

    public <T> String fromBean(Object objectBean, Class<T> convertClass, String encoding) {
        try {
            return mapper.writeValueAsString(objectBean);
        }
        catch (IOException e) {
            throw new RuntimeException(e.getCause());
        }
    }
}
