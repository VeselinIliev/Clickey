using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : Spell
{
    private void Start()
    {
        damage = 25;
        particleSystemPrefab = Resources.Load("Spells/ParticleSystems/FireBall") as GameObject;
        speed = 2f;
        base.Start();
    }



    public override void Cast()
    {
        base.Cast();
    }
}