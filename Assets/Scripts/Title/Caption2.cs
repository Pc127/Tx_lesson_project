using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Caption2 : MonoBehaviour
{
    public GameObject t1;

    public GameObject t2;

    public GameObject t3;

    public int interval = 5;

    // Start is called before the first frame update
    void Start()
    {
        this.Invoke("First", interval);
    }

    // Update is called once per frame
    void First()
    {
        t1.SetActive(false);
        t2.SetActive(true);
        this.Invoke("Second", interval);
    }

    void Second()
    {
        t2.SetActive(false);
        t3.SetActive(true);
        this.Invoke("Third", interval);
    }

    void Third()
    {
        SceneManager.LoadScene("scene3");
    }
}
