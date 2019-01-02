using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashTrigger : MonoBehaviour
{
    public GameObject flash;

    private bool enable = false;


    public void Update()
    {
        if (enable)
        {
            if (GamePersist.GetInstance().hero.interEnable)
            {
                flash.SetActive(true);
                this.Invoke("Disact", 0.3f);
            }
        }
    }

    public void Disact()
    {
        flash.SetActive(false);
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
