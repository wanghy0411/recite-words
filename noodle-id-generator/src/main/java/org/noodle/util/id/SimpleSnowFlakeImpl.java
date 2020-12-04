package org.noodle.util.id;

import java.util.Random;

/**
 * twitter的snowflake算法 -- java实现
 *
 * @author beyond
 * 2016/11/26
 * modified by wanghy 设定数据中心和机器码均为1, 扩大序列号位数, 使用随机序列号
 */
public class SimpleSnowFlakeImpl implements SnowFlake {

    /**
     * 起始的时间戳
     */
    private final static long START_TIMESTAMP = 1480166465631L;

    /**
     * 序列号占用的位数
     */
    private final static long SEQUENCE_BIT = 20;
    /**
     * 机器标识占用的位数
     */
    private final static long MACHINE_BIT = 1;
    /**
     * 数据中心占用的位数
     */
    private final static long DATA_CENTER_BIT = 1;

    /**
     * 每一部分的最大值
     */
    private final static long MAX_SEQUENCE = ~(-1L << SEQUENCE_BIT);

    /**
     * 每一部分向左的位移
     */
    private final static long MACHINE_LEFT = SEQUENCE_BIT;
    private final static long DATA_CENTER_LEFT = SEQUENCE_BIT + MACHINE_BIT;
    private final static long TIMESTAMP_LEFT = DATA_CENTER_LEFT + DATA_CENTER_BIT;

    /**
     * 上一次时间戳
     */
    private long lastTimestamp = -1L;

    /**
     * 随机数对象
     */
    private final Random random = new Random(1);

    /**
     * 产生下一个ID
     */
    public synchronized long nextId() {
        long currTimestamp = getNewTimestamp();
        long sequence = Math.abs(random.nextLong()) & MAX_SEQUENCE;

        lastTimestamp = currTimestamp;

        //数据中心, 机器标识
        long dataCenterId = 1, machineId = 1;
        return (currTimestamp - START_TIMESTAMP) << TIMESTAMP_LEFT //时间戳部分
                | dataCenterId << DATA_CENTER_LEFT       //数据中心部分
                | machineId << MACHINE_LEFT             //机器标识部分
                | sequence;                             //序列号部分
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
            if (diffTimestamp>300) {
                throw new RuntimeException("Clock moved backwards.  Refusing to generate id");
            }

            currTimestamp = getNextMill();
        }
        return currTimestamp;
    }

    public static void main(String[] args) {
        SnowFlake snowFlake = new SimpleSnowFlakeImpl();

        for (int i = 0; i < (1 << 12); i++) {
            System.out.println(snowFlake.nextId());
        }

    }
}