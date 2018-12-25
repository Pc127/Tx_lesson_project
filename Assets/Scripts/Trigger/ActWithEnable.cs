using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActWithEnable : MonoBehaviour
{
    // 需要激活的物体
    public GameObject actSth;

    private bool enable = false;

    public void Update()
    {
        if (enable)
        {
            if (GamePersist.GetInstance().hero.interEnable)
            {
                this.actSth.SetActive(true);
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
        this.enable = false;
    }
}
