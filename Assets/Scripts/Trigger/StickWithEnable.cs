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
                GamePersist.GetInstance().hero.interEnable = false;


            }
        }
    }

    private void stick()
    {
        Debug.Log("stick");
        GamePersist.GetInstance().hero.transform.parent = this.transform;
        GamePersist.GetInstance().hero.moveEnable = false;
        GamePersist.GetInstance().hero.DisableGravity();
        isStick = true;
    }

    private void unStick()
    {
        Debug.Log("Unstick");
        GamePersist.GetInstance().hero.transform.parent = this.pretrans.transform;
        GamePersist.GetInstance().hero.moveEnable = true;
        GamePersist.GetInstance().hero.EnableGravity();
        GamePersist.GetInstance().hero.KeepVertical();
        isStick = false;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<Hero>() != null)
        {
            this.enable = true;
        }
        
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<Hero>() != null)
        {
            this.enable = false;
            unStick();
        }
    }
}
