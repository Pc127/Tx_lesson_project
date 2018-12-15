using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeTrigger : MonoBehaviour {

    private bool enable = false;

    public GameObject ladder;

    // 小树与刚体一起长大 把人物顶上去
    public void GrowUp()
    {
        ladder.SetActive(true);
        this.gameObject.SetActive(false);

    }

    public void Update()
    {
        if (enable)
        {
            if (GamePersist.GetInstance().hero.interEnable)
            {
                GrowUp();
            }
        }
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        GamePersist.GetInstance().hero.DoAWarn("发现一棵需要浇水的小树苗");
        this.enable = true;

    }

    public void OnTriggerExit2D(Collider2D other)
    {
        this.enable = false;
    }
}
