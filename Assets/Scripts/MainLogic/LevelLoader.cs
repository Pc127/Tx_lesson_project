using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour {

    public GameObject levelContainer;
    public GameObject floors;

    // 从一层起
    private int currentLevel;
    private int count = 0;
    
	void Start () {
        this.currentLevel = 1;

        GameObject f = Instantiate(this.floors);
        f.transform.parent = this.levelContainer.transform;
        f.transform.localPosition = new Vector2(0, 0);
        f.transform.localScale = new Vector3(1, 1, 1);
    }
	
	void Update () {
		if ( GamePersist.GetInstance().currentLevel > currentLevel)
        {
            this.currentLevel++;
            this.count = 125;
            

        }
        if( count != 0)
        {
            this.levelContainer.transform.localPosition = new Vector2(0, this.levelContainer.transform.localPosition.y-2);
            //GamePersist.GetInstance().hero.transform.localPosition = new Vector2(0, GamePersist.GetInstance().hero.transform.localPosition.y - 2);
            count--;
        }
	}
}
