using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour {

    // Use this for initialization
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
