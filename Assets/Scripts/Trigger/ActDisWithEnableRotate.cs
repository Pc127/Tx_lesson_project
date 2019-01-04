using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActDisWithEnableRotate : MonoBehaviour
{
    public GameObject actSth;

    public GameObject disactSth;

    private bool enable = false;


    public void Update()
    {
        if (enable)
        {
            if (GamePersist.GetInstance().hero.interEnable)
            {
                disactSth.SetActive(false);
                actSth.SetActive(true);
                this.gameObject.GetComponent<RectTransform>().Rotate(new Vector3(0, 0, 90));
                GamePersist.GetInstance().hero.interEnable = false;
            }
        }
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        this.enable = true;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        this.enable = false;
    }
}
