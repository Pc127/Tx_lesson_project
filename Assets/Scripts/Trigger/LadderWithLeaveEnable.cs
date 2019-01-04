using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderWithLeaveEnable : MonoBehaviour
{
    public GameObject actObj1;

    public GameObject actObj2;

    public GameObject disObj;
    // 触发梯子，会使人物只能垂直移动
    private bool enable = false;

    public void Update()
    {
        if (enable)
        {
            if (GamePersist.GetInstance().hero.joy.movement.y > 0.5 || Input.GetKey(KeyCode.W))
            {
                GamePersist.GetInstance().hero.horzEnable = !GamePersist.GetInstance().hero.horzEnable;
                GamePersist.GetInstance().hero.vertEnable = !GamePersist.GetInstance().hero.vertEnable;
                GamePersist.GetInstance().hero.DisableGravity();
                enable = false;
            }
        }
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        this.enable = true;

    }

    public void OnTriggerStay2D(Collider2D other)
    {
        this.enable = true;

    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (GamePersist.GetInstance().hero.GetY() >= 284)
        {
            this.enable = false;
            GamePersist.GetInstance().hero.horzEnable = true;
            GamePersist.GetInstance().hero.vertEnable = false;
            actObj1.SetActive(true);
            actObj2.SetActive(true);
            disObj.SetActive(false);
            this.gameObject.SetActive(false);
        }
        GamePersist.GetInstance().hero.EnableGravity();

    }
}
