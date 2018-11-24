using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {


    // 把人物移动到上一层
    void OnTriggerStay2D(Collider2D other)
    {
        if (GamePersist.GetInstance().hero.interEnable)
        {
            Debug.Log("移动向上一层");
            GamePersist.GetInstance().hero.HeroMove(new Vector2(0, 250));
            GamePersist.GetInstance().currentLevel++;
            GamePersist.GetInstance().hero.DoNotInter();
        }
    }
}
