using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.GetComponent<Hero>() != null)
        {
            GamePersist.GetInstance().hero.jumpEnable = true;
            Debug.Log("与地板碰撞");

        }
        
    }

    private void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.GetComponent<Hero>() != null)
        {
            GamePersist.GetInstance().hero.jumpEnable = false;
            Debug.Log("离开地板");

        }
    }
}
