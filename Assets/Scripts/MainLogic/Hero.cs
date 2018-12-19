using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hero : MonoBehaviour {

    public GameObject warn;

    public JoyStick joy;
    // 是否可以移动
    public bool moveEnable = true;
    // 是否可以左右移动
    public bool horzEnable = true;
    // 是否可以上下移动
    public bool vertEnable = false;
    // 是否可以跳跃
    public bool jumpEnable = true;
    // 是否处于interAct
    public bool interEnable = false;
    // 是否拿到了钥匙和水
    public bool keyAndWater = false;
    // 获取转轴的移动向量
    private Vector2 movement;

    private Rigidbody2D rigidbody;

    private Vector2 pos;
    // 速度
    private float speed = 140.0f;
    private float Gravity = 100f;
    // 跳跃高度
    private float jumpForce = 500.0f;
    private float jumpHight = 3500f;

    private void Start()
    {
        this.rigidbody = this.GetComponent<Rigidbody2D>();
        GamePersist.GetInstance().hero = this;
    }

    // 每帧进行移动
    void Update () {
        //this.pos = this.GetComponent<Transform>().localPosition;
        //Debug.Log(pos.y);
        movement = joy.movement;
        // 不控制向上跳跃
        if(horzEnable == false)
            movement.x = 0;
        if (vertEnable == false)
            movement.y = 0;
        if (horzEnable) this.rigidbody.velocity = new Vector2(movement.x * this.speed, this.rigidbody.velocity.y);
        if (vertEnable) this.rigidbody.velocity = new Vector2(this.rigidbody.velocity.x, movement.y * this.speed);

        //double bundle

        float horKey = Input.GetAxis("Horizontal");
        float verKey = Input.GetAxis("Vertical");
        //Debug.Log(movement.ToString());
        if (Input.GetKey(KeyCode.A)&& horzEnable)
        {
            //Debug.Log("A Down");
            this.rigidbody.velocity = new Vector2(-1.5f * this.speed, this.rigidbody.velocity.y);
            //transform.position += new Vector3(-1f * this.speed, 0,0);
        }
        if (Input.GetKey(KeyCode.D)&& horzEnable)
        {
            //Debug.Log("D Down");
            this.rigidbody.velocity = new Vector2(1.5f * this.speed, this.rigidbody.velocity.y);
            //transform.position += new Vector3( 1f * this.speed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("Space Down");
            Jump();
        }
    }

    // 跳跃函数
    public void Jump()
    {
        Debug.Log("调用jump");
        if (jumpEnable)
        {
            Vector2 jump = new Vector2(0, Mathf.Sqrt(2f*jumpHight*Gravity));
            Debug.Log(jump);
            Debug.Log(this.rigidbody.gravityScale);
            this.rigidbody.velocity += new Vector2(0 , jump.y);
            //this.rigidbody.AddForce(jump);
        }
    }

    // 移动位置的函数
    public void HeroMove(Vector2 movement)
    {
        this.gameObject.GetComponent<RectTransform>().transform.localPosition = new Vector3(movement.x,movement.y ,0);
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

    // 对于重力的处理
    public void DisableGravity()
    {
        this.rigidbody.gravityScale = 0;
    }

    public void EnableGravity()
    {
        this.rigidbody.gravityScale = Gravity;
    }

    private void MoveDisable()
    {
        horzEnable = false;
        //vertEnable = false;
    }

    private void MoveEnable()
    {
        horzEnable = true;
        //vertEnable = true;
    }

    // 施加碰撞力
    public void AddForce(int force)
    {
        Vector2 myForce = new Vector2(-1 * force, 0);
        MoveDisable();
        this.rigidbody.velocity = new Vector2(-Mathf.Sqrt(2f * jumpHight * Gravity), Mathf.Sqrt(2f * jumpHight * Gravity)/1.5f);
        this.Invoke("MoveEnable", 0.3f);
        //this.rigidbody.AddForce(myForce);
    }
}
