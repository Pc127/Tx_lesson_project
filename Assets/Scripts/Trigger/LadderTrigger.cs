using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderTrigger : MonoBehaviour {

    private bool enable = false;
   
    public void Update()
    {
        if (enable)
        {
            Debug.Log("碰到梯子");
            Debug.Log(GamePersist.GetInstance().hero.interEnable);
            if (GamePersist.GetInstance().hero.interEnable)
            {
                Debug.Log("触发");
                GamePersist.GetInstance().hero.horzEnable = !GamePersist.GetInstance().hero.horzEnable;
                GamePersist.GetInstance().hero.vertEnable = !GamePersist.GetInstance().hero.vertEnable;
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
        GamePersist.GetInstance().hero.horzEnable = true;
        GamePersist.GetInstance().hero.vertEnable = false;

    }
}
