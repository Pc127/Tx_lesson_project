using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceWithoutEnable : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<Hero>() != null)
        {
            Debug.Log("与水滴碰撞");
            GamePersist.GetInstance().hero.DoAWarn("好痛");
            GamePersist.GetInstance().hero.AddForce(10000000);
            //GamePersist.GetInstance().hero.velocity();
        }
    }
}
