using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryWithoutEnable : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Hero>() != null)
        {
            Destroy(this.gameObject);
        }
    }
}
