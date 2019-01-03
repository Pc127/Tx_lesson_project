using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterGrow : MonoBehaviour
{
    public RectTransform rect;

    public BoxCollider2D box;

    private int speed = 1;


    // Update is called once per frame
    void Update()
    {
        if(rect.localScale.y < 170)
        {
            rect.localScale = new Vector3(1, (rect.localScale.y) + speed, 0);
            box.size = new Vector2(140, rect.localScale.y + speed);
        }
    }
}
