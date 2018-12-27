using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour {

    // 进入碰撞体时，取消重力，并使人物可以跳跃
    public void OnTriggerEnter2D(Collider2D other)
    {
        GamePersist.GetInstance().hero.jumpEnable = true;
        GamePersist.GetInstance().hero.DisableGravity();

    }

    public void OnTriggerExit2D(Collider2D other)
    {
        GamePersist.GetInstance().hero.jumpEnable = false;
        GamePersist.GetInstance().hero.EnableGravity();
    }
}
