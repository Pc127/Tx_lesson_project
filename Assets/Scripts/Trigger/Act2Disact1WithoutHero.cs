using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Act2Disact1WithoutHero : MonoBehaviour
{
    public GameObject actObj;

    public GameObject actObj2;

    public GameObject disactObj;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Hero>() == null)
        {
            actObj.SetActive(true);
            actObj2.SetActive(true);
            disactObj.SetActive(false);
        }
    }
}
