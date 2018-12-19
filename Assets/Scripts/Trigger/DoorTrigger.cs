using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {


    // 把人物移动到上一层
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Hero>() != null)
        {
            Debug.Log("移动向上一层");
            GamePersist.GetInstance().hero.HeroMove(new Vector2(-220, 210));
            //GamePersist.GetInstance().currentLevel++;
        }
    }
}
