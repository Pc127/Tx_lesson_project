using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour {

    private Slider slider;

    // 获取slider
	void Start () {
        this.slider = GetComponent<Slider>();
	}
	
	// 根据水位高度更新slider
	void Update () {
        this.slider.value = this.slider.value + 0.01f;
	}
}
