using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLevel : MonoBehaviour {

    private int waterSpeed = 1;
	// Update is called once per frame
	void Update () {
        GamePersist.GetInstance().waterHeight = GamePersist.GetInstance().waterHeight + this.waterSpeed;
        if(GamePersist.GetInstance().GetDiff() < 0)
        {
            this.GetComponent<RectTransform>().sizeDelta = new Vector2( 600, -1 * GamePersist.GetInstance().GetDiff());
        }

    }
}
