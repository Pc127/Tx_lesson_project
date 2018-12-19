using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnOfPicTrigger : MonoBehaviour
{
    public GameObject sth;

    public GameObject sthLadder;
    private bool enable = false;


    public void Update()
    {
        if (enable)
        {
            if (GamePersist.GetInstance().hero.interEnable)
            {
                sth.SetActive(false);
                sthLadder.SetActive(true);
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
