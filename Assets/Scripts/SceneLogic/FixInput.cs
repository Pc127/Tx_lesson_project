using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FixInput : MonoBehaviour
{
    // 需要激活的valve
    public GameObject valve; 
    // 十二块电路
    public RectTransform r0;
    public RectTransform r1;
    public RectTransform r2;
    public RectTransform r3;
    public RectTransform r4;
    public RectTransform r5;
    public RectTransform r6;
    public RectTransform r7;
    public RectTransform r8;
    public RectTransform r9;
    public RectTransform r10;
    public RectTransform r11;
    // 保存十二张图片，用来旋转
    private RectTransform[] btn = new RectTransform[12];
    // 正确的旋转角度
    private int[] correct = new int[12] {0,270,0, 270,0,0,0,0,90,0,180,90};
    // 当前的旋转角度 1 4 11错位
    private int[] precent = new int[12] { 0, 90, 0, 270, 90, 0, 0, 0, 90, 0, 180, 270 };
    // 特殊的位置有 4 5 6 7

    // Start is called before the first frame update
    void Start()
    {
        // 保存图片
        btn[0] = r0;
        btn[1] = r1;
        btn[2] = r2;
        btn[3] = r3;
        btn[4] = r4;
        btn[5] = r5;
        btn[6] = r6;
        btn[7] = r7;
        btn[8] = r8;
        btn[9] = r9;
        btn[10] = r10;
        btn[11] = r11;
    }

    public void Check()
    {
        Debug.Log(precent);
        bool isSuccess = true;
        for(int i = 0; i < 12; i++)
        {
            if (i >= 4 && i <= 7)
            {
                int diff = (precent[i] - correct[i]) % 180;
                if(diff != 0)
                {
                    Debug.Log(i + "的数值不对，应该是" + correct[i] + "但它是" + precent[i]);
                    isSuccess = false;
                    break;
                }
            }
            else if (precent[i] != correct[i])
            {
                Debug.Log(i + "的数值不对，应该是" + correct[i] + "但它是" + precent[i]);
                isSuccess = false;
                break;
            }
        }

        if (isSuccess)
        {
            Success();
        }
    }

    public void Success()
    {
        valve.SetActive(true);
        this.gameObject.SetActive(false);
    }

    public void Btn(int i)
    {
        precent[i] = (precent[i] + 90)%360;
        btn[i].Rotate(new Vector3(0,0,90));
        Check();
    }

}
