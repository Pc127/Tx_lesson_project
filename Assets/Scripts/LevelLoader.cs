using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour {

    public GameObject levelContainer;

    public GameObject f1Pre;

    public GameObject f2Pre;

    private int currentLevel;

    private int count;

	// Use this for initialization
	void Start () {
        this.currentLevel = 1;

        GameObject f1 = Instantiate(this.f1Pre);
        f1.transform.parent = this.levelContainer.transform;
        f1.transform.localPosition = new Vector2(0, 0);

        GameObject f2 = Instantiate(this.f2Pre);
        f2.transform.parent = this.levelContainer.transform;
        f2.transform.localPosition = new Vector2(0, 250);
    }
	
	// Update is called once per frame
	void Update () {
		if ( GamePersist.GetInstance().roleHeight >= currentLevel * 250)
        {
            this.currentLevel++;
            this.count = 250;
            

        }
        if( count != 0)
        {
            this.levelContainer.transform.Translate(new Vector2(0, -1));
            GamePersist.GetInstance().hero.transform.Translate(new Vector2(0, -1));
            count--;
        }
	}
}
