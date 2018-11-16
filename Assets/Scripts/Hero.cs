using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

    public JoyStick joy;

    // 获取转轴的移动向量
    private Vector2 movement;

    // 速度
    private float speed = 5.0f;

    private void Start()
    {
        GamePersist.GetInstance().Init(0, 0, 0, 0);
    }

    // 每帧进行移动
    void Update () {
        movement = joy.movement;
        Debug.Log(movement);
        //this.transform.Translate(movement * 5, 0);
        Debug.Log(GamePersist.GetInstance().buildHeight);
    }

}
