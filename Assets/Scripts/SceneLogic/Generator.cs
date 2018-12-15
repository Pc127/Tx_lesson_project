using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

    public GameObject sth;

    // livetime要小于interval
    private float interval = 3f;

    private float speed = 100;

    private float livetime = 1f;

    private float count = 0;

    private void Start()
    {
        DoCreate();
    }

    // 间隔执行
    void Update () {
		if(count > interval)
        {
            count = 0;
            DoCreate();

        }
        else
        {
            count += Time.deltaTime;
        }
	}

    void DoCreate()
    {
        GameObject th = Instantiate(this.sth);
        th.transform.parent = this.transform;
        th.transform.localPosition = new Vector2(0, 0);
        th.transform.localScale = new Vector3(1, 1, 1);
        th.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1 * this.speed);
        this.Invoke("DoDestroy", this.livetime);
    }

    private void DoDestroy()
    {   // 删除所有子节点
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }
}
