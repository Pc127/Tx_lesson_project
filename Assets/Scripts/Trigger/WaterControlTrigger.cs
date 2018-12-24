using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterControlTrigger : MonoBehaviour
{
    // 需要激活的
    public GameObject sthEn;

    // 相对
    public GameObject sthDis;

    private bool enable = false;

    public void Update()
    {
        if (enable)
        {
            if (GamePersist.GetInstance().hero.interEnable)
            {
                if(sthEn != null)
                {
                    sthEn.SetActive(true);
                }
                if(sthDis != null)
                {
                    sthDis.SetActive(false);
                }
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
