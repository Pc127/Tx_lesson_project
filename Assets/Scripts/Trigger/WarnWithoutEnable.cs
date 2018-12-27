using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarnWithoutEnable : MonoBehaviour {

    public string warnStr = "";


    public void OnTriggerEnter2D(Collider2D other)
    {
        GamePersist.GetInstance().hero.DoAWarn(warnStr);
    }
}
