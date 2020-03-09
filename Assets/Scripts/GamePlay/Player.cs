using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int level = 1;
    private int strength = 10;
    private int agility = 10;
    private int intellingece = 10;
    private int command = 0;

    private void Awake()
    {
        if(PlayerPrefs.HasKey("level"))
        {
            UpdateStats();
        }
        else
        {
            SetDefaultStats();
        }

    }

    private void UpdateStats()
    {
        level = PlayerPrefs.GetInt("level");
        strength = PlayerPrefs.GetInt("str");
        agility = PlayerPrefs.GetInt("agi");
        intellingece = PlayerPrefs.GetInt("int");
        command = PlayerPrefs.GetInt("comm");
    }

    private void SetDefaultStats()
    {
        PlayerPrefs.SetInt("level", 1);
        PlayerPrefs.SetInt("str", 10);
        PlayerPrefs.SetInt("agi", 10);
        PlayerPrefs.SetInt("int", 10);
        PlayerPrefs.SetInt("comm", 0);
        PlayerPrefs.Save();
    }


    public static List<int> GetStats()
    {
        List<int> stats = new List<int>();

        return stats;
    }

    public void IncrementStr()
    {
        strength++;
    }

    public void IncrementAgi()
    {
        agility++;
    }

    public void IncrementInt()
    {
        intellingece++;
    }


}
