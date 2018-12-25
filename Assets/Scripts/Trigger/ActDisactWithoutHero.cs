using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActDisactWithoutHero : MonoBehaviour {

    public GameObject actObj;

    public GameObject disactObj;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Hero>() == null)
        {
            actObj.SetActive(true);
            disactObj.SetActive(false);
        }
    }
}
