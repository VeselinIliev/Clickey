using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    
    public void LoadFightScene()
    {
        SceneManager.LoadScene("FightScene");
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    } public static void LoadFightSceneStatic()
    {
        SceneManager.LoadScene("FightScene");
    }

    public static  void LoadGameSceneStatic()
    {
        SceneManager.LoadScene("Game");
    }

    public static void LoadMainMenuStatic()
    {
        SceneManager.LoadScene("MainMenu");
    }





}
