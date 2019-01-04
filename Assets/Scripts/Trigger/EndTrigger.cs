using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Hero>() != null)
        {
            GamePersist.GetInstance().waterHeight = 0;
           
        }
    }
}
