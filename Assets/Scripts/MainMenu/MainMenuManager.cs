using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    Button start;

    private void Start()
    {
        start = GameObject.Find("Start").GetComponent<Button>();

        start.onClick.AddListener(StartGame);
     
    }

    void StartGame()
    {
        SceneManager.LoadScene("Game");
    }



}
