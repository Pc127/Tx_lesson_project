using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotat : MonoBehaviour
{
    public int angle = 90;

    private bool enable = false;


    public void Update()
    {
        if (enable)
        {
            if (GamePersist.GetInstance().hero.interEnable)
            {
                this.gameObject.GetComponent<RectTransform>().Rotate(new Vector3(0,0,angle));
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
