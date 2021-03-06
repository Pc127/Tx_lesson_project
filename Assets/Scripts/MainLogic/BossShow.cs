﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossShow : MonoBehaviour
{
    public GameObject warn;


    private void Start()
    {
        DoAWarn("这个甲烷处理器，好费电，我还是关了吧");
        
        this.Invoke("First", 2);
    }

    public void First()
    {
        GamePersist.GetInstance().hero.DoAWarn("这个甲烷净化器是用来净化废气的");
        this.Invoke("Second", 2);
    }

    public void Second()
    {
        GamePersist.GetInstance().hero.DoAWarn("工厂在运转，怎么能说关就关");
    }

    public void DoAWarn(string str)
    {
        GameObject w = Instantiate(this.warn);
        w.transform.parent = this.transform;
        w.transform.localPosition = new Vector2(0, 70);
        w.GetComponentInChildren<Text>().text = str;
        //this.paramOfDoNotWarn = w;
        this.Invoke("DoOtherWarn", 3);
    }
    public void DoOtherWarn()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        GameObject w = Instantiate(this.warn);
        w.transform.parent = this.transform;
        w.transform.localPosition = new Vector2(0, 70);
        w.GetComponentInChildren<Text>().text = "哈哈，关掉了，这个月又省好多电";
        //this.paramOfDoNotWarn = w;
        this.Invoke("DoNotWarn", 5);
    }
    public void DoNotWarn()
    {
        this.gameObject.SetActive(false);
    }
}
