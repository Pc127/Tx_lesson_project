using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassS2Trigger : MonoBehaviour
{
    private bool enable = false;

    public void Update()
    {
        if (enable)
        {
            if (GamePersist.GetInstance().hero.interEnable)
            {
                GamePersist.GetInstance().hero.DoAWarn("为小树苗浇了水");
                enable = false;
            }
        }
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        GamePersist.GetInstance().hero.DoAWarn("发现一棵需要浇水的小树苗");
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
