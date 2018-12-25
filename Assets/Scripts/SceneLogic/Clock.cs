using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public GameObject stick;

    //最大旋转角度
    private float maxm = 0.35f;

    private float minm = -0.35f;

    // 旋转速度
    private float speed = 0.1f;

    private bool isPuls = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float presentZ = this.stick.GetComponent<RectTransform>().rotation.z;

        // Debug.Log(this.stick.GetComponent<RectTransform>().localRotation);
        // Debug.Log(this.stick.GetComponent<RectTransform>().rotation);

        if(presentZ >= maxm || presentZ <= minm)
        {
            this.isPuls = !this.isPuls;
        }

        if (isPuls)
        {
            //Debug.Log("增加");
            //this.stick.GetComponent<RectTransform>().localRotation.Set(0, 0, presentZ + this.speed, 1);
            this.stick.GetComponent<RectTransform>().Rotate(new Vector3(0, 0, speed));
        }
        else
        {
            // Debug.Log("减少");
            //this.stick.GetComponent<RectTransform>().localRotation.Set(0, 0, presentZ - this.speed, 1);
            this.stick.GetComponent<RectTransform>().Rotate(new Vector3(0, 0, -1 * speed));
        }

    }
}
