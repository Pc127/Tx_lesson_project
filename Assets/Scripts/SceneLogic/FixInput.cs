using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FixInput : MonoBehaviour
{
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
    private int[] correct = new int[12];
    // 当前的旋转角度
    private int[] precent = new int[12];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Check()
    {

    }

}
