using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrostBall : Spell
{
    private void Start()
    {
        speed = 4;
        Damage = 10;
        particleSystemPrefab = Resources.Load("Spells/ParticleSystems/FrostBall") as GameObject;
        base.Start();

    }


    public override void Cast()
    {
        base.Cast();
    }
}
