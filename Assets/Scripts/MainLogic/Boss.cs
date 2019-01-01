using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{

    public GameObject warn;

    private Rigidbody2D rigidbody;

    private Vector2 force;

    private Vector2[] pos =  new Vector2[5];
    // image组件
    private Image image;

    private void Start()
    {
        pos[0] = new Vector2();
        pos[1] = new Vector2();
        pos[2] = new Vector2();
        pos[3] = new Vector2();
        pos[4] = new Vector2();
        this.rigidbody = this.GetComponent<Rigidbody2D>();
        image = this.GetComponent<Image>();
    }

    private void Update()
    {
       // 688
       // 888
       // 1188 3个月
       // 170 5047 6836 黄小姐
    }

}

