using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLevel : MonoBehaviour {

    // 根据waterlevel来配置
    // 同时更新涨水速度
    private void Start()
    {
        this.GetComponent<RectTransform>().sizeDelta = new Vector2(600, 0);
        GamePersist.GetInstance().waterHeight = -10;
    }

    // 下降速度
    private float waterSpeed = 0.2f;
	// Update is called once per frame
	void Update () {
        GamePersist.GetInstance().waterHeight = GamePersist.GetInstance().waterHeight + this.waterSpeed;
        if (GamePersist.GetInstance().waterHeight > 0)
        {
            // 600为宽度 剩下为长度
            this.GetComponent<RectTransform>().sizeDelta = new Vector2( 600, GamePersist.GetInstance().waterHeight);
        }
    }
}
