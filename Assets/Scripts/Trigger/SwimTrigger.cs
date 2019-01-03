using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwimTrigger : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D other)
    {
        GamePersist.GetInstance().hero.horzEnable = true;
        GamePersist.GetInstance().hero.vertEnable = true;
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        GamePersist.GetInstance().hero.horzEnable = true;
        GamePersist.GetInstance().hero.vertEnable = true;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        GamePersist.GetInstance().hero.horzEnable = true;
        GamePersist.GetInstance().hero.vertEnable = false;
    }
}
