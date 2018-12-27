using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    private int speed = 30;

    //高点
    private int startPoint = 80;

    //低点
    private int endPoint = -80;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,-speed);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(this.gameObject.GetComponent<RectTransform>().localPosition);
        if(this.gameObject.GetComponent<RectTransform>().localPosition.y >= startPoint)
            this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
        if(this.gameObject.GetComponent<RectTransform>().localPosition.y <= endPoint)
            this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);

    }
}
