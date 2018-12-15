using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTrigger : MonoBehaviour {

    public GameObject nofire;
	// Use this for initialization
	void Start () {
		
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Hero>() == null)
        {
            Debug.Log("被浇灭了");
            nofire.SetActive(true);
            this.gameObject.SetActive(false);

        }
    }
}
