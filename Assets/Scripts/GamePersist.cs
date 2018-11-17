using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePersist {

    public int roleHeight;

    public int screenHeight;

    public int buildHeight;

    public int waterHeight;

    public Hero hero;
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
    private GamePersist()
    {
        this.Init(0, 0, 0, -100);
    }

    // 提供一个初始化方法
    public void Init(int role, int screen, int build, int water)
    {
        this.roleHeight = role;
        this.screenHeight = screen;
        this.buildHeight = build;
        this.waterHeight = water;
    }

    // 人与水位之差
    public int GetDiff()
    {
        return this.buildHeight - this.waterHeight;
    }
}
