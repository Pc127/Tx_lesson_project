using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public float speed = 0.5f;

    //高点
    public int startPoint = 80;

    //低点
    public int endPoint = -40;

    private RectTransform re;

    private bool down = true;

    void Start()
    {
        //this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,-speed);
        re = this.gameObject.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(this.gameObject.GetComponent<RectTransform>().localPosition);
        if (this.gameObject.GetComponent<RectTransform>().localPosition.y >= startPoint)
            down = true;
        if(this.gameObject.GetComponent<RectTransform>().localPosition.y <= endPoint)
            down=false;

        if (down)
            re.localPosition = new Vector3(re.localPosition.x, re.localPosition.y - speed, 0);
        else
            re.localPosition = new Vector3(re.localPosition.x, re.localPosition.y + speed, 0);

    }
}
