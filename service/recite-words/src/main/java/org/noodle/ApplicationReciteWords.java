package org.noodle;

import org.mybatis.spring.annotation.MapperScan;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.transaction.annotation.EnableTransactionManagement;

@SpringBootApplication
@EnableTransactionManagement
@MapperScan("org.noodle.orm.mapper")
public class ApplicationReciteWords {
    public static void main(String[] args) {
        SpringApplication.run(ApplicationReciteWords.class,args);
    }
}
