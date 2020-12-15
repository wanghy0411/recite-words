package org.noodle.util.id;

import java.util.Random;

/**
 * 雪花算法, 数据中心和机器号随机生成
 * 多节点运行时, 数据中心和机器标识通过随机数获取, 降低了id获取的重复可能, 但不能真正保证id的唯一性;
 * @author wanghy
 */
public class RandomMachineSnowFlakeImpl implements SnowFlake {
    private final SnowFlake simpleSnowFlake;

    public RandomMachineSnowFlakeImpl() {
        final Random random = new Random();
        long dataCenterId = random.nextLong() & SimpleSnowFlakeImpl.MAX_DATA_CENTER;
        long machineId = random.nextLong() & SimpleSnowFlakeImpl.MAX_MACHINE;
        simpleSnowFlake = new SimpleSnowFlakeImpl(dataCenterId, machineId);
    }

    public synchronized long nextId() {
        return simpleSnowFlake.nextId();
    }

    public static void main(String[] args) {
        SnowFlake snowFlake = new RandomMachineSnowFlakeImpl();

        for (int i = 0; i < (1 << 10); i++) {
            System.out.println(i+":"+snowFlake.nextId());
        }
    }
}
