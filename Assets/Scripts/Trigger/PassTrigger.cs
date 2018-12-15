using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassTrigger : MonoBehaviour {


    public void OnTriggerExit2D(Collider2D other)
    {
         GamePersist.GetInstance().currentLevel = GamePersist.GetInstance().currentLevel + 1;
    }
}
