using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public GameObject lv;

    private bool enable = false;


    public void Update()
    {
        if (enable)
        {
            
            if (GamePersist.GetInstance().hero.interEnable&& lv.transform.localPosition.y <10)
            {
                GamePersist.GetInstance().waterHeight = 0;
                GamePersist.GetInstance().hero.DoAWarn("我还是做到了");
                GamePersist.GetInstance().hero.moveEnable = false;
                this.Invoke("Frist", 3);
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

    private void Frist()
    {
        GamePersist.GetInstance().hero.DoAWarn("我终于把它关掉了");
        this.Invoke("Second",3 );
    }

    private void Second()
    {
        SceneManager.LoadScene("caption3");
    }
}
