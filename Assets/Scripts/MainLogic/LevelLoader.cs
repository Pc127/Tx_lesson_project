using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour {

    public GameObject levelContainer;
    // public GameObject floors;

    // 从一层起
    private int currentLevel;
    private int upcount = 0;
    private int downcount = 0;
    
	void Start () {
        this.currentLevel = 1;

        //GameObject f = Instantiate(this.floors);
        //f.transform.parent = this.levelContainer.transform;
        //f.transform.localPosition = new Vector2(0, 0);
        //f.transform.localScale = new Vector3(1, 1, 1);
    }
	
	void Update () {
        
        // 计算楼层
        float nowHeight = GamePersist.GetInstance().hero.transform.localPosition.y;
        //Debug.Log(nowHeight);
        nowHeight += 125f;
        GamePersist.GetInstance().currentLevel = (int)(nowHeight / 250f) +1;
        
		if (GamePersist.GetInstance().currentLevel > currentLevel)
        {
            this.currentLevel++;
            this.upcount += 50;
        }else if (GamePersist.GetInstance().currentLevel < currentLevel)
        {
            this.currentLevel--;
            this.downcount += 50;
        }

        if(upcount >0 && downcount > 0)
        {
            if (upcount > downcount)
            {
                upcount -= downcount;
                downcount = 0;
            }
            else
            {
                downcount -= upcount;
                upcount = 0;
            }
        }
        if( upcount != 0)
        {
            this.levelContainer.transform.localPosition = new Vector2(0, this.levelContainer.transform.localPosition.y - 5);
            //GamePersist.GetInstance().hero.transform.localPosition = new Vector2(0, GamePersist.GetInstance().hero.transform.localPosition.y - 2);
            upcount--;
        }
        if (downcount != 0)
        {
            this.levelContainer.transform.localPosition = new Vector2(0, this.levelContainer.transform.localPosition.y + 5);
            //GamePersist.GetInstance().hero.transform.localPosition = new Vector2(0, GamePersist.GetInstance().hero.transform.localPosition.y - 2);
            downcount--;
        }
    }
}
