using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrostBall : Spell
{
    private void Start()
    {
        speed = 4;
        damage = 10;
        particleSystemPrefab = Resources.Load("Spells/ParticleSystems/AcidBall") as GameObject;
        base.Start();

    }


    public override void Cast()
    {
        base.Cast();
    }
}
