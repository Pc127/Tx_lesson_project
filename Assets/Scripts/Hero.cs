using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

    public JoyStick joy;

    // 获取转轴的移动向量
    private Vector2 movement;

    private Rigidbody2D rigidbody;

    // 速度
    private float speed = 500.0f;

    private void Start()
    {
        GamePersist.GetInstance().Init(0, 0, 0, -100);
        this.rigidbody = this.GetComponent<Rigidbody2D>();
        GamePersist.GetInstance().hero = this;
    }

    // 每帧进行移动
    void Update () {
        movement = joy.movement;
        //this.transform.Translate(movement * 5, 0);
        this.rigidbody.AddForce(movement * this.speed);
    }

    public void HeroMove(Vector2 movement)
    {
        this.transform.Translate(movement);
        GamePersist.GetInstance().roleHeight = GamePersist.GetInstance().roleHeight + (int)movement.y; 
    }

}
