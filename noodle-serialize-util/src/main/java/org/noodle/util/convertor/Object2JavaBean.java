package org.noodle.util.convertor;

import org.noodle.util.json.JsonParser;

public class Object2JavaBean {
    public static <T> T toBean(Object sourceObj, Class<T> convertClass) {
        JsonParser parser = JsonParser.getSingleInstance();
        return parser.toBean(parser.fromBean(sourceObj, Object.class), convertClass);
    }
}
