using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Item : MonoBehaviour, ICollectable, IHaveStats
{
    private int bonusStr;
    private int bonusAgi;
    private int bonusInt;
    private int bonusComm;
    public int BonusStr { get => bonusStr; set => bonusStr = value; }
    public int BonusAgi { get => bonusAgi; set => bonusAgi = value; }
    public int BonusInt { get => bonusInt; set => bonusInt = value; }
    public int BonusComm { get => bonusComm; set => bonusComm = value; }

    public string GetStats()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("str : ");
        sb.Append(BonusStr.ToString());
        sb.Append("\nagi :");
        sb.Append(BonusAgi.ToString());

        return sb.ToString();
    }

    private void Start()
    {
        SetRandomStats();
    }

    void SetRandomStats()
    {
        BonusStr = Random.Range(0, 100);
        BonusAgi = Random.Range(0, 100);
        bonusInt = Random.Range(0, 100);
        BonusComm = Random.Range(0, 100);
    }

}
