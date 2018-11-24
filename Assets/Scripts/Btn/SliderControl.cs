using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour {

    private Slider slider;

    private int maxm = 100;
    // 获取slider
	void Start () {
        this.slider = GetComponent<Slider>();
	}
	
	// 根据水位高度更新slider
	void Update () {
         // Debug.Log("水位高度" + GamePersist.GetInstance().waterHeight);
        this.slider.value = (100 - GamePersist.GetInstance().GetDiff()) *1.0f / this.maxm;
	}
}
