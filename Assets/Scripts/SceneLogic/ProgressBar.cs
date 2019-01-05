using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBar : MonoBehaviour
{
    public RectTransform index;

    public GameObject obj1;

    public GameObject obj2;

    public GameObject obj3;

    public GameObject obj4;

    public GameObject dis1;

    public GameObject dis2;

	public RectTransform pro;

    private int count=0;

    private int length=200;

    private int max_count=10;

    // 时间
    private float time_count = 0;
    private float interval = 0.35f;

    public void Update()
    {
        time_count += Time.deltaTime;
        if (time_count >= interval)
        {
            time_count -= interval;
            if(count>0)
            --count;
        }
        
        if (GamePersist.GetInstance().hero.interEnable)
        {
            GamePersist.GetInstance().hero.interEnable = false;
            ++count;
            if (count >= max_count)
                Success();
        }

        index.localPosition = new Vector3(-100 + (length * 1.0f / max_count * count), 0, 0);
		pro.localScale = new Vector3 (length * 1.0f / max_count * count, 1, 1);
    }

    public void Success()
    {
        obj1.SetActive(true);
        obj2.SetActive(true);
        obj3.SetActive(true);
        obj4.SetActive(true);
        dis1.SetActive(false);
        dis2.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
