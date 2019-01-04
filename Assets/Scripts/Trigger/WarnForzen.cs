using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarnForzen : MonoBehaviour
{
    public string str;

    public string str2;

    public string str3;

    public void OnTriggerEnter2D(Collider2D other)
    {
        GamePersist.GetInstance().hero.DoAWarn(str);
        GamePersist.GetInstance().hero.moveEnable = false;
        this.Invoke("Enable", 4);
        this.Invoke("Second", 2);
    }

    public void Enable()
    {
        GamePersist.GetInstance().hero.moveEnable = true;
    }

    public void Second()
    {
        GamePersist.GetInstance().hero.DoAWarn(str2);
        this.Invoke("Third", 3);
    }

    public void Third()
    {
        GamePersist.GetInstance().hero.DoAWarn(str3);
    }
}
