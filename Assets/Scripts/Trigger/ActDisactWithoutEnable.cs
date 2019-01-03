using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActDisactWithoutEnable : MonoBehaviour {
    public GameObject actSth;

    public GameObject disactSth;
	// Use this for initialization


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<Hero>() != null)
        {
            this.disactSth.SetActive(false);
            this.actSth.SetActive(true);
        }
    }
}
