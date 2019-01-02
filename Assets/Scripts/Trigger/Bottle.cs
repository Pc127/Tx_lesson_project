using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bottle : MonoBehaviour
{
    public Sprite broken;

    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.GetComponent<Hero>() != null)
        {
            this.Invoke("breakBottle", 2);
        }
    }

    private void breakBottle(){
        GamePersist.GetInstance().boss.enable = true;
        this.GetComponent<Image>().overrideSprite = broken;
        this.GetComponent<RectTransform>().localScale = new Vector3(2, 1, 0);
    }
}
