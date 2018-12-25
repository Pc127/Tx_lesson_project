using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoorTrigger : MonoBehaviour
{
    private bool enable = false;

    public void Update()
    {
        if (enable)
        {
            if (GamePersist.GetInstance().hero.interEnable)
            {
                if (GamePersist.GetInstance().hero.keyAndWater == true)
                {
                    GamePersist.GetInstance().hero.HeroMove(new Vector2(0, 0));
                }
                else {
                    GamePersist.GetInstance().hero.DoAWarn("门被锁住");
                }
                
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
