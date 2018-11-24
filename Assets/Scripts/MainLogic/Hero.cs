using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hero : MonoBehaviour {

    public GameObject warn;

    public JoyStick joy;

    public bool jumpEnable = true;

    public bool interEnable = false;
    // 获取转轴的移动向量
    private Vector2 movement;

    private Rigidbody2D rigidbody;

    // 速度
    private float speed = 200.0f;
    
    // 跳跃高度
    private float jumpForce = 5000.0f;

    private void Start()
    {
        this.rigidbody = this.GetComponent<Rigidbody2D>();
        GamePersist.GetInstance().hero = this;
    }

    // 每帧进行移动
    void Update () {
        movement = joy.movement;
        // 不控制向上跳跃
        movement.y = 0;
        this.rigidbody.AddForce(movement * this.speed);
    }

    // 跳跃函数
    public void Jump()
    {
        // Debug.Log("调用jump");
        if (jumpEnable)
        {
            Vector2 jump = new Vector2(0, jumpForce);
            this.rigidbody.AddForce(jump);
        }
    }

    // 移动位置的函数
    public void HeroMove(Vector2 movement)
    {
        this.transform.Translate(movement);
    }

    // 调用提示UI
    private void DoNotWarn()
    {   // 删除所有子节点
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }

    public void DoAWarn(string str)
    {
        GameObject w = Instantiate(this.warn);
        w.transform.parent = this.transform;
        w.transform.localPosition = new Vector2(0, 70);
        w.GetComponentInChildren<Text>().text = str;
        //this.paramOfDoNotWarn = w;
        this.Invoke("DoNotWarn", 2);
    }

    // 调用interact
    public void DoInter()
    {
        this.interEnable = true;
        this.Invoke("DoNotInter", 0.2f);
    }

    public void DoNotInter()
    {
        this.interEnable = false;
    }
}
