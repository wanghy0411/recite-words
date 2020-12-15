package org.noodle.util.id;

import org.springframework.util.Assert;

/**
 * twitter的snowflake算法 -- java实现
 * 需传入数据中心和机器标识号
 * @author beyond
 * 2016/11/26
 * modified by wanghy
 */
public class SimpleSnowFlakeImpl implements SnowFlake {
    /**
     * 起始的时间戳2020-1-1
     */
    private final static long START_TIMESTAMP = 1577808000000L;
    /**
     * 序列号占用的位数, 10位代表每个服务每ms最多取512个id
     */
    protected final static long SEQUENCE_BIT = 9;
    /**
     * 机器标识占用的位数, 9位代表一个数据中心最多有1024个服务可以同时获取id
     */
    protected final static long MACHINE_BIT = 10;
    /**
     * 数据中心占用的位数, 3位代表最多可以有8个数据中心
     */
    protected final static long DATA_CENTER_BIT = 3;
    /**
     * 数据中心最大值
     */
    protected final static long MAX_DATA_CENTER = ~(-1L << DATA_CENTER_BIT);
    /**
     * 机器标识最大值
     */
    protected final static long MAX_MACHINE = ~(-1L << MACHINE_BIT);
    /**
     * 序号最大值
     */
    private final static long MAX_SEQUENCE = ~(-1L << SEQUENCE_BIT);
    /**
     * 每一部分向左的位移
     */
    private final static long MACHINE_LEFT     = SEQUENCE_BIT;
    private final static long DATA_CENTER_LEFT = SEQUENCE_BIT + MACHINE_BIT;
    private final static long TIMESTAMP_LEFT   = SEQUENCE_BIT + MACHINE_BIT + DATA_CENTER_BIT;

    /**
     * 上一次时间戳
     */
    private long lastTimestamp = -1L;

    /**
     * 自增变量
     */
    private long sequence=0;
    /**
     * 数据中心
     */
    private final long dataCenterId;
    /**
     * 机器标识
     */
    private final long machineId;

    public SimpleSnowFlakeImpl(long dataCenterId, long machineId) {
        Assert.isTrue(dataCenterId>=0 && dataCenterId<=MAX_DATA_CENTER, "传入的数据中心标识超过了允许的范围[0-"+MAX_DATA_CENTER+"]");
        Assert.isTrue(machineId>=0 && machineId<=MAX_MACHINE, "传入的数据中心标识超过了允许的范围[0-"+MAX_MACHINE+"]");
        this.dataCenterId = dataCenterId;
        this.machineId = machineId & MAX_MACHINE;
    }

    /**
     * 产生下一个ID
     */
    public synchronized long nextId() {
        long currTimestamp = getNewTimestamp();

        sequence = (sequence + 1) & MAX_SEQUENCE;
        //已经达到最大值, 则取下一时间戳
        if (sequence == 0 && lastTimestamp == currTimestamp) {
            currTimestamp = getNextMill();
        }
        lastTimestamp = currTimestamp;

        return (currTimestamp - START_TIMESTAMP) << TIMESTAMP_LEFT  //时间戳部分
                | dataCenterId << DATA_CENTER_LEFT                  //数据中心部分
                | machineId << MACHINE_LEFT                         //机器标识部分
                | sequence;                                         //序列号部分
    }

    private long getNextMill() {
        long mill = getNewTimestamp();
        while (mill <= lastTimestamp) {
            mill = getNewTimestamp();
        }
        return mill;
    }

    private long getNewTimestamp() {
        long currTimestamp = System.currentTimeMillis();

        //如果有时钟回拨, 且时钟回拨在300ms以内, 延时后返回, 否则抛异常
        if (currTimestamp < lastTimestamp) {
            long diffTimestamp = lastTimestamp - currTimestamp;
            if (diffTimestamp>1) {
                throw new RuntimeException("服务器时钟调整, 暂时不能获取唯一id");
            }

            currTimestamp = getNextMill();
        }
        return currTimestamp;
    }
}