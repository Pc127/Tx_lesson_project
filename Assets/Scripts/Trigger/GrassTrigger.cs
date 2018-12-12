using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassTrigger : MonoBehaviour {

    private bool enable = false;

    public void Update()
    {
        if (enable)
        {
            Debug.Log("碰到梯子");
            Debug.Log(GamePersist.GetInstance().hero.interEnable);
            if (GamePersist.GetInstance().hero.interEnable)
            {
                GamePersist.GetInstance().hero.DoAWarn("为小树苗浇了水，海水貌似暂停了上涨");
                enable = false;
            }
        }
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        GamePersist.GetInstance().hero.DoAWarn("发现一棵需要浇水的小树苗");
        this.enable = true;

    }

    public void OnTriggerStay2D(Collider2D other)
    {
        this.enable = true;

    }

    public void OnTriggerExit2D(Collider2D other)
    {
        this.enable = false;
    }
}
