using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hero : MonoBehaviour {

    public GameObject warn;

    public JoyStick joy;
    // 三张图片 
    public Sprite sp1;
    public Sprite sp2;
    public Sprite sp3;
    public Sprite sp01;
    public Sprite sp02;
    public Sprite sp03;
    private int spindex = 1;
    private bool spright = true;
    // 两帧动画的间隔
    private float spinterval = 0.2f;
    private float spcount = 0;
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
    // image组件
    private Image image;

    private void Start()
    {
        this.rigidbody = this.GetComponent<Rigidbody2D>();
        GamePersist.GetInstance().hero = this;
        image = this.GetComponent<Image>();
    }

    // 每帧进行移动
    void Update () {
        // 控制动画
        spcount += Time.deltaTime;
        Debug.Log(spcount);
        Debug.Log(spindex);
        if (spcount > spinterval)
        {   // 123的循环
            spcount -= spinterval;
            spindex = spindex % 4 +1;
            if (spindex == 1)
            {
                image.overrideSprite = spright ? sp1 : sp01;
                this.GetComponent<RectTransform>().localScale = new Vector3(1,1,0); ;
            }
            else if (spindex == 2)
            {
                image.overrideSprite = spright ? sp2 : sp02;
                this.GetComponent<RectTransform>().localScale = new Vector3(0.8f, 1, 0);
            }
            else if (spindex == 3)
            {
                image.overrideSprite = spright ? sp3 : sp03;
                this.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 0);
            }

            else if (spindex == 4) {
                image.overrideSprite = spright ? sp2 : sp02;
                this.GetComponent<RectTransform>().localScale = new Vector3(0.8f, 1, 0);
            }
                
        }
        if (movement.x < 0)
            spright = false;
        else if (movement.x > 0)
            spright = true;

        movement = joy.movement;
        // 不控制向上跳跃
        if (horzEnable == false)
            movement.x = 0;
        if (vertEnable == false)
            movement.y = 0;
        if (horzEnable) this.rigidbody.velocity = new Vector2(movement.x * this.speed, this.rigidbody.velocity.y);
        if (vertEnable) this.rigidbody.velocity = new Vector2(this.rigidbody.velocity.x, movement.y * this.speed);


        float horKey = Input.GetAxis("Horizontal");
        float verKey = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.A)&& horzEnable)
        {
            this.rigidbody.velocity = new Vector2(-1.5f * this.speed, this.rigidbody.velocity.y);
        }
        if (Input.GetKey(KeyCode.D)&& horzEnable)
        {
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

    public void KeepVertical()
    {
        this.GetComponent<RectTransform>().rotation = new Quaternion(0, 0, 0, 0);
    }
}
