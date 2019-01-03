using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBar : MonoBehaviour
{
    public RectTransform index;

    public GameObject obj1;

    public GameObject obj2;

    public GameObject obj3;

    private int count=0;

    private int length=200;

    private int max_count=10;

    public void Update()
    {
        if (GamePersist.GetInstance().hero.interEnable)
        {
            GamePersist.GetInstance().hero.interEnable = false;
            ++count;
            if (count >= max_count)
                Success();
            index.localPosition = new Vector3(-100+(length*1.0f/max_count*count),0,0);
        }
    }

    public void Success()
    {
        obj1.SetActive(true);
        obj2.SetActive(true);
        obj3.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
