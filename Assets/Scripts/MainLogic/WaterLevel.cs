using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterLevel : MonoBehaviour {

    private bool isDead = false;
    // 根据waterlevel来配置
    // 同时更新涨水速度
    // 监控主角是否死亡
    private void Start()
    {
        this.GetComponent<RectTransform>().sizeDelta = new Vector2(600, 0);
        GamePersist.GetInstance().waterHeight = -10;
    }

    // 下降速度
    private float waterSpeed = 0.2f;
	// Update is called once per frame
	void Update () {
        // 判断是否死亡
        if (GamePersist.GetInstance().waterHeight >= GamePersist.GetInstance().currentLevel * 250&&!isDead&&GamePersist.GetInstance().hero.deadable)
            Dead();
        GamePersist.GetInstance().waterHeight = GamePersist.GetInstance().waterHeight + this.waterSpeed;
        if (GamePersist.GetInstance().waterHeight > 0)
        {
            // 600为宽度 剩下为长度
            this.GetComponent<RectTransform>().sizeDelta = new Vector2( 600, GamePersist.GetInstance().waterHeight);
        }
    }

    void Dead()
    {
        isDead = true;
        GamePersist.GetInstance().hero.moveEnable = false;
        GamePersist.GetInstance().hero.DoAWarn("我真的不行了");
        this.Invoke("Restart", 3);
    }

    void Restart()
    {
        if(GamePersist.GetInstance().buildNum == 1)
            SceneManager.LoadScene("caption1");
        else if(GamePersist.GetInstance().buildNum == 2)
            SceneManager.LoadScene("caption2");
    }
}
