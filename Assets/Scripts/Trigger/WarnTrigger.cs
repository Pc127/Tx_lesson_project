using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarnTrigger : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        GamePersist.GetInstance().hero.DoAWarn("快涨水了，快向上走吧");
    }
}
