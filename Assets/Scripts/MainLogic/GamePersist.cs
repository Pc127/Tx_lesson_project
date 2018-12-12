using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 暴露出来当前
public class GamePersist {

    // 当前楼层
    public int currentLevel;
    // 保存一个hero变量，hero变量向GamePersist注册自己
    public Hero hero;
    // 水位高度
    public int waterHeight;
    // 每层楼层高度
    private int preLevelHeight;

    // 设计为单例模式
    private static GamePersist gamePersist = null;

    // 获取单例
    public static GamePersist GetInstance()
    {
        if (GamePersist.gamePersist == null)
            GamePersist.gamePersist = new GamePersist();
        return GamePersist.gamePersist;
    }

    // 构造方法封装
    // 定义水位初始高度
    private GamePersist()
    {
        this.Init(-100, 1, 250);
    }

    // 提供一个初始化方法
    // 参数为：初始水位 当前楼层 每层楼高
    public void Init(int water, int current, int pre)
    {
        this.waterHeight = water;
        this.currentLevel = current;
        this.preLevelHeight = pre;
    }

    // 人与水位之差
    public int GetDiff()
    {
        return this.currentLevel * this.preLevelHeight - this.waterHeight;
    }
}
