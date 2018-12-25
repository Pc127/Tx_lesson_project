using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActDisactWithoutEnable : MonoBehaviour {
    public GameObject actSth;

    public GameObject disactSth;
	// Use this for initialization


    public void OnTriggerEnter2D(Collider2D other)
    {
        this.disactSth.SetActive(false);
        this.actSth.SetActive(true);
    }
}
