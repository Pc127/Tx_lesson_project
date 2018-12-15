using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLadderTrigger : MonoBehaviour {
    public GameObject rope;

    public GameObject ropeLadder;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("放梯子");
        this.rope.SetActive(false);
        this.ropeLadder.SetActive(true);


    }
}
