using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : IBonusStats
{
    private int bonusStr;
    private int bonusAgi;
    private int bonusInt;
    private int bonusComm;
    public int BonusStr { get => bonusStr; set => bonusStr = value; }
    public int BonusAgi { get => bonusAgi; set => bonusAgi = value; }
    public int BonusInt { get => bonusInt; set => bonusInt = value; }
    public int BonusComm { get => bonusComm; set => bonusComm = value; }

    public Stats(int str, int agi, int intel, int comm)
    {
        BonusStr = str;
        BonusAgi = agi;
        BonusInt = intel;
        bonusComm = comm;
    }

    public string GetStats()
    {
        return this.ToString();
    }

    public override string ToString()
    {
        return $"Str : {BonusStr}\nAgi : {BonusAgi}\nInt : {BonusInt}\nComm : {BonusComm}";
    }

}
