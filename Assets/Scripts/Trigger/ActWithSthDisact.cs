using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActWithSthDisact : MonoBehaviour
{
    public GameObject obj;

    public GameObject sth;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(sth.active == false)
        {
            obj.SetActive(true);
        }
        
    }
}
