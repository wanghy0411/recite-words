package org.noodle.autoconfig;

import org.noodle.util.id.SimpleSnowFlakeImpl;
import org.noodle.util.id.SnowFlake;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.stereotype.Component;

import java.util.Iterator;
import java.util.ServiceLoader;

@Configuration
@Component
public class SnowFlakeConfig {
    @Bean
    public SnowFlake snowFlake() {
        SnowFlake snowFlake = null;

        ServiceLoader<SnowFlake> loadedServices = ServiceLoader.load(SnowFlake.class);
        Iterator<SnowFlake> servicesIterator = loadedServices.iterator();
        try{
            if (servicesIterator.hasNext()) {
                snowFlake = servicesIterator.next();
            }
        } catch(Throwable t) {
            // Do nothing
        }

        if (snowFlake==null) {
            snowFlake = new SimpleSnowFlakeImpl();
        }
        return snowFlake;
    }
}
