using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hero : MonoBehaviour {

    public GameObject warn;

    public JoyStick joy;
    // 是否可以左右移动
    public bool horzEnable = true;
    // 是否可以上下移动
    public bool vertEnable = false;
    // 是否可以跳跃
    public bool jumpEnable = true;
    // 是否处于interAct
    public bool interEnable = false;

    // 获取转轴的移动向量
    private Vector2 movement;

    private Rigidbody2D rigidbody;

    // 速度
    private float speed = 100.0f;
    
    // 跳跃高度
    private float jumpForce = 150000.0f;

    private void Start()
    {
        this.rigidbody = this.GetComponent<Rigidbody2D>();
        GamePersist.GetInstance().hero = this;
    }

    // 每帧进行移动
    void Update () {
        movement = joy.movement;
        // 不控制向上跳跃
        if(horzEnable == false)
            movement.x = 0;
        if (vertEnable == false)
            movement.y = 0;
        this.rigidbody.velocity = (movement * this.speed);
    }

    // 跳跃函数
    public void Jump()
    {
        Debug.Log("调用jump");
        if (jumpEnable)
        {
            Vector2 jump = new Vector2(0, jumpForce);
            //this.rigidbody.velocity = new Vector2(100000000, 100000000);
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
        Debug.Log("调用inter");
        this.interEnable = true;
        this.Invoke("DoNotInter", 0.2f);
    }

    public void DoNotInter()
    {
        this.interEnable = false;
    }

    public void DisableGravity()
    {
        this.rigidbody.gravityScale = 0;
    }

    public void EnableGravity()
    {
        this.rigidbody.gravityScale = 100f;
    }
}
