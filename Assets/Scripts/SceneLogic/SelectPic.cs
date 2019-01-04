using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPic : MonoBehaviour
{
    public GameObject pic;

    public GameObject btn;

    public void Wrong()
    {
        this.gameObject.SetActive(false);
        GamePersist.GetInstance().hero.DoAWarn("好像不是这幅画");
    }

    public void Right()
    {
        this.gameObject.SetActive(false);
        this.pic.SetActive(false);
        this.btn.SetActive(true);
    }
}
