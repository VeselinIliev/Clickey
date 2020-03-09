using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int level = 1;
    private int experience = 0;
    private int strength = 10;
    private int agility = 10;
    private int intellingece = 10;
    private int command = 0;

    public int Level
    {
        get => level;
        set { level = value;
            PlayerPrefs.SetInt("level", value);
        }
    }

    public int Experience
    {
        get => experience;
        set
        { 
            experience = value;
            PlayerPrefs.SetInt("exp", value);
        }
    }

    public int Strength
    {
        get => strength;
        set
        {
            strength = value;
            PlayerPrefs.SetInt("str", value);
        }
    }

    public int Agility
    {
        get => agility;
        set
        {
            agility = value;
            PlayerPrefs.SetInt("agi", value);
        }
    }

    public int Intellingece
    {
        get => intellingece;
        set
        {
            intellingece = value;
            PlayerPrefs.SetInt("int", value);
        }
    }

    public int Command
    {
        get => command;
        set
        {
            command = value;
            PlayerPrefs.SetInt("comm", value);
        }
    }

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
        experience = PlayerPrefs.GetInt("exp");
        Strength = PlayerPrefs.GetInt("str");
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
        PlayerPrefs.SetInt("exp",0);
        PlayerPrefs.Save();
    }


    public static List<int> GetStats(Player player)
    {
        List<int> stats = new List<int>();
        stats.Add(player.Level);
        stats.Add(player.Experience);
        stats.Add(player.Strength);
        stats.Add(player.Agility);
        stats.Add(player.Intellingece);
        stats.Add(player.command);
        
        return stats;
    }

    public List<int> GetCurrentPlayerStats()
    {
       return GetStats(this);
    }

    public void IncrementStr()
    {
        Strength++;
    }

    public void IncrementAgi()
    {
        Agility++;
    }

    public void IncrementInt()
    {
        Intellingece++;
    }



}
