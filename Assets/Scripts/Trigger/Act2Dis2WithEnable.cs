using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Act2Dis2WithEnable : MonoBehaviour
{
    public GameObject actSth;

    public GameObject actSth2;

    public GameObject disactSth;

    public GameObject disactSth2;

    private bool enable = false;


    public void Update()
    {
        if (enable)
        {
            if (GamePersist.GetInstance().hero.interEnable)
            {
                disactSth.SetActive(false);
                disactSth2.SetActive(false);
                actSth.SetActive(true);
                actSth2.SetActive(true);
                GamePersist.GetInstance().hero.interEnable = false;
            }
        }
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        this.enable = true;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        this.enable = false;
    }
}
