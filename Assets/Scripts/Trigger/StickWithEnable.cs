using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickWithEnable : MonoBehaviour
{
    public GameObject pretrans;

    private bool isStick = false;
    private bool enable = false;

    public void Update()
    {
        if (enable)
        {
            if (GamePersist.GetInstance().hero.interEnable)
            {
                if (!isStick)
                {
                    stick();
                }
                else
                {
                    unStick();
                }
                
            }
        }
    }

    private void stick()
    {
        GamePersist.GetInstance().hero.transform.parent = this.transform;
        GamePersist.GetInstance().hero.moveEnable = false;
        GamePersist.GetInstance().hero.DisableGravity();
        isStick = true;
    }

    private void unStick()
    {
        GamePersist.GetInstance().hero.transform.parent = this.pretrans.transform;
        GamePersist.GetInstance().hero.moveEnable = true;
        GamePersist.GetInstance().hero.EnableGravity();
        isStick = false;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        this.enable = true;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        this.enable = false;
        unStick();
    }
}
