using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : Spell
{
    private void Start()
    {
        speed = 2f;
        damage = 25;
        particleSystemPrefab = Resources.Load("Spells/ParticleSystems/FireBall") as GameObject;
        base.Start();
    }



    public override void Cast()
    {
        base.Cast();
    }
}