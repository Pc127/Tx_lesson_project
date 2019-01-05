using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{

    public GameObject warn;

    private Vector2 force;

    private Vector2[] pos =  new Vector2[4];
    // image组件
    private Image image;

    private int end = 1;

    private int start = 0;

    public float speed = 0.3f;

    [HideInInspector]
    public bool enable = false;

    private void Start()
    {
        GamePersist.GetInstance().boss = this;
        // boss行动路线
        pos[0] = new Vector2(228,0);
        pos[1] = new Vector2(60,0);
        pos[2] = new Vector2(-90,-65);
        pos[3] = new Vector2(-120,-65);
        image = this.GetComponent<Image>();
        this.enable = false;
		DoAWarn ("灯怎么黑了");
    }

    private void Update()
    {
        if (enable)
        {
            Vector2 now = this.GetComponent<RectTransform>().transform.localPosition;
            Debug.Log(now);
            Vector2 diff = pos[end] - pos[start];
            now = now + diff.normalized * speed;
            Vector2 len = now - pos[start];
            // 如果now - start 大于等于 diff
            if (len.SqrMagnitude() >= diff.SqrMagnitude())
            {
                now = pos[end];
                if (end == 0)
                {
                    start = 0;
                    end = 1;
                }else if(end == 3)
                {
                    start = 3;
                    end = 2;
                }
                else
                {
                    int i = end;
                    end += end - start;
                    start = i;
                }
               
            }
            this.GetComponent<RectTransform>().transform.localPosition = now;
        }
        
    }

	public void DoAWarn(string str)
	{
		foreach (Transform child in transform)
		{
			Destroy(child.gameObject);
		}

		GameObject w = Instantiate(this.warn);
		w.transform.parent = this.transform;
        w.GetComponent<RectTransform>().localScale = new Vector3(0.5f, 0.5f, 0);
		w.transform.localPosition = new Vector2(0, 70);
		w.GetComponentInChildren<Text>().text = str;
	}

}

