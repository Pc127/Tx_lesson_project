using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActWithoutHero : MonoBehaviour
{
    public GameObject actObj;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Hero>() == null)
        {
            actObj.SetActive(true);
        }
    }
}
