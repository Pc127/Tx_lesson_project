using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTrigger : MonoBehaviour {

    private bool enable = false;
    private float heroY;
    private void Update()
    {
        if (enable)
        {
            //this.transform.Translate()
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (GamePersist.GetInstance().hero.interEnable)
        {
            GamePersist.GetInstance().hero.interEnable = false;
        }
    }
}
