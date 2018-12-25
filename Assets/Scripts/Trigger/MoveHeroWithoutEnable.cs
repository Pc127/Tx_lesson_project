using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHeroWithoutEnable : MonoBehaviour {


    public int toX;

    public int toY;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Hero>() != null)
        {
            Debug.Log("移动向上一层");
            GamePersist.GetInstance().hero.HeroMove(new Vector2(toX, toY));
            //GamePersist.GetInstance().currentLevel++;
        }
    }
}
