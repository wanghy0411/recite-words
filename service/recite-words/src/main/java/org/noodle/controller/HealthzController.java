package org.noodle.controller;

import org.noodle.orm.mapper.DictionaryMapper;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import javax.annotation.Resource;

/**
 * 健康检查服务
 * @author wanghy
 */
@RestController
@RequestMapping("/")
public class HealthzController {
    @Resource
    private DictionaryMapper dictionaryMapper;
    @RequestMapping(value = "/healthz",method = {RequestMethod.POST, RequestMethod.GET})
    public String healthz() {
        dictionaryMapper.selectByPrimaryKey(0L);
        return "success";
    }
}
