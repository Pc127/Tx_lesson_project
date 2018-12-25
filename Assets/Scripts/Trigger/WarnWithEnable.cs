using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarnWithEnable : MonoBehaviour
{
    public string warnStr = "";

    private bool enable = false;

    public void Update()
    {
        if (enable)
        {
            if (GamePersist.GetInstance().hero.interEnable)
            {
                GamePersist.GetInstance().hero.DoAWarn(warnStr);
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
        this.enable = false;
    }
}
