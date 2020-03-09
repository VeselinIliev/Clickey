using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHaveStats
{
     int BonusStr { get; set; }
     int BonusAgi { get; set; }
     int BonusInt { get; set; }
     int BonusComm { get; set; }

     string GetStats();
}