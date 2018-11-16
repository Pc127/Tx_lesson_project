using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

    public JoyStick joy;

    // 获取转轴的移动向量
    private Vector2 movement;

    private Rigidbody2D rigidbody;

    // 速度
    private float speed = 200.0f;

    private void Start()
    {
        GamePersist.GetInstance().Init(0, 0, 0, -100);
        this.rigidbody = this.GetComponent<Rigidbody2D>();
    }

    // 每帧进行移动
    void Update () {
        movement = joy.movement;
        Debug.Log(movement);
        //this.transform.Translate(movement * 5, 0);
        this.rigidbody.AddForce(movement * this.speed);
        Debug.Log(GamePersist.GetInstance().buildHeight);
    }

}
