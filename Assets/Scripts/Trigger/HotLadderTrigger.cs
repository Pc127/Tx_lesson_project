using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotLadderTrigger : MonoBehaviour
{
    public GameObject fire;

    public GameObject ladder;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(fire.active == false)
        {
            ladder.SetActive(true);
        }
        
    }
}
