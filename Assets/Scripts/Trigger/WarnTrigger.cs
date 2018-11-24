using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarnTrigger : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        GamePersist.GetInstance().hero.DoAWarn("请按交互键开门");
    }
}
