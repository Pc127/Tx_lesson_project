using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActDis2WithoutHero : MonoBehaviour
{
    public GameObject actObj;

    public GameObject disactObj1;

    public GameObject disactObj2;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Hero>() == null)
        {
            actObj.SetActive(true);
            disactObj2.SetActive(false);
            disactObj1.SetActive(false);
        }
    }
}
