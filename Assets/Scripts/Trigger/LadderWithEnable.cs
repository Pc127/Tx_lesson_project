﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderWithEnable : MonoBehaviour {

    // 触发梯子，会使人物只能垂直移动
    private bool enable = false;
   
    public void Update()
    {
        if (enable)
        {
            if (GamePersist.GetInstance().hero.joy.movement.y > 0.2 || Input.GetKey(KeyCode.W))
            {
                GamePersist.GetInstance().hero.horzEnable = false; //!GamePersist.GetInstance().hero.horzEnable;
                GamePersist.GetInstance().hero.vertEnable = true;  //!GamePersist.GetInstance().hero.vertEnable;
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
        GamePersist.GetInstance().hero.EnableGravity();
        this.enable = false;
        GamePersist.GetInstance().hero.horzEnable = true;
        GamePersist.GetInstance().hero.vertEnable = false;

    }
}
