using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNextScene : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.GetComponent<Hero>() != null)
        {
            this.Invoke("ToNext", 5);
            GamePersist.GetInstance().waterHeight = 250.0f * 8.1f;

        }
    }

    void ToNext()
    {
        SceneManager.LoadScene("caption2");
        GamePersist.GetInstance().waterHeight = 0;
    }
}
