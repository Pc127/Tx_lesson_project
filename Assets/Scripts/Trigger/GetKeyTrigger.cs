using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyTrigger : MonoBehaviour
{

    private bool enable = false;

    public void Update()
    {
        if (enable)
        {
            if (GamePersist.GetInstance().hero.interEnable)
            {
                GamePersist.GetInstance().hero.keyAndWater = true;
                GamePersist.GetInstance().hero.DoAWarn("拿到了水和钥匙");
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
