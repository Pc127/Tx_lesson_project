using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init : MonoBehaviour
{
    public int BuildingNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        GamePersist.GetInstance().buildNum = BuildingNum;
        GamePersist.GetInstance().waterHeight = -10;
    }
}
