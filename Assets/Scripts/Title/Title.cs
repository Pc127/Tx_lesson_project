using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {

    // 定义了进入游戏场景
    public void EnterGame()
    {
        SceneManager.LoadScene("game_scene");
    }
}
