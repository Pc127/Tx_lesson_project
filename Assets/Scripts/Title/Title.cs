using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {

    // 定义了进入游戏场景
    public void EnterGame1()
    {
        SceneManager.LoadScene("caption1");
    }
    //定义退出游戏
    public void QuitGame()
    {
        Application.Quit();
    }
    //定义退回到主菜单
    public void BacktoTitle()
    {
        SceneManager.LoadScene("main_title");
    }
    //定义前往场景3,目前切换到场景3水位未重置
    public void EnterGame2()
    {
        SceneManager.LoadScene("caption2");
    }
}
