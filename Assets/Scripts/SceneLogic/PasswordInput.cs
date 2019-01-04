using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordInput : MonoBehaviour
{
    public GameObject safeTrigger;
    public GameObject exitTrigger;
    public GameObject doorTrigger;
    public GameObject machineTrigger;
    public GameObject key;
    // 输出的目标
    public Image i0;
    public Image i1;
    public Image i2;
    public Image i3;
    public Image i4;
    public Image i5;
    public Image i6;
    public Image i7;
    // 数字
    public Sprite n0;
    public Sprite n1;
    public Sprite n2;
    public Sprite n3;
    public Sprite n4;
    public Sprite n5;
    public Sprite n6;
    public Sprite n7; 
    public Sprite n8;
    public Sprite n9;
    // 待输入
    public Sprite n;

    // 保存了数字
    private Sprite[] num = new Sprite[11];

    // 显示的板子
    private Image[] show = new Image[8];

    //保存当前输入
    private int inputIndex = 0;

    private string str;

    public void Start()
    {
        // 初始化数字
        num[0] = n0;
        num[1] = n1;
        num[2] = n2;
        num[3] = n3;
        num[4] = n4;
        num[5] = n5;
        num[6] = n6;
        num[7] = n7;
        num[8] = n8;
        num[9] = n9;
        num[10] = n;
        // 初始化显示板
        show[0] = i0;
        show[1] = i1;
        show[2] = i2;
        show[3] = i3;
        show[4] = i4;
        show[5] = i5;
        show[6] = i6;
        show[7] = i7;
    }

    public void ClearShow()
    {
        str = "";
        inputIndex = 0;
        foreach (var image in show)
        {
            image.overrideSprite = num[10];
        }
    }

    public void Input0()
    {
        str += "0";
        show[inputIndex].overrideSprite = num[0];
        if (inputIndex < 7)
            inputIndex++;
    }

    public void Input1()
    {
        str += "1";
        show[inputIndex].overrideSprite = num[1];
        if (inputIndex < 7)
            inputIndex++;
    }

    public void Input2()
    {
        str += "2";
        show[inputIndex].overrideSprite = num[2];
        if (inputIndex < 7)
            inputIndex++;
    }

    public void Input3()
    {
        str += "3";
        show[inputIndex].overrideSprite = num[3];
        if (inputIndex < 7)
            inputIndex++;
    }

    public void Input4()
    {
        str += "4";
        show[inputIndex].overrideSprite = num[4];
        if (inputIndex < 7)
            inputIndex++;
    }

    public void Input5()
    {
        str += "5";
        show[inputIndex].overrideSprite = num[5];
        if (inputIndex < 7)
            inputIndex++;
    }

    public void Input6()
    {
        str += "6";
        show[inputIndex].overrideSprite = num[6];
        if (inputIndex < 7)
            inputIndex++;
    }

    public void Input7()
    {
        str += "7";
        show[inputIndex].overrideSprite = num[7];
        if (inputIndex < 7)
            inputIndex++;
    }

    public void Input8()
    {
        str += "8";
        show[inputIndex].overrideSprite = num[8];
        if (inputIndex < 7)
            inputIndex++;
    }

    public void Input9()
    {
        str += "9";
        show[inputIndex].overrideSprite = num[9];
        if (inputIndex < 7)
            inputIndex++;
    }

    public void InputSure()
    {
        if (str == "65162524")
            Success();
        else
            ClearShow();
    }

    public void Success()
    {
        GamePersist.GetInstance().hero.DoAWarn("终于拿到了开关的钥匙");
        key.SetActive(true);
        safeTrigger.SetActive(false);
        exitTrigger.SetActive(true);
        doorTrigger.SetActive(false);
        machineTrigger.SetActive(true);
        DisActive();
    }

    public void DisActive()
    {
        this.gameObject.SetActive(false);
    }
}
