using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassTrigger : MonoBehaviour {


    public void OnTriggerExit2D(Collider2D other)
    {
        if (GamePersist.GetInstance().currentLevel == 1)
            GamePersist.GetInstance().currentLevel = 2;
        else
            GamePersist.GetInstance().currentLevel = 1;
    }
}
