﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell : MonoBehaviour, ISpell
{
    private SpellType spellType;
    public SpellType SpellType { get => spellType; set => spellType = value; }

    public int Damage;

    public GameObject particleSystemPrefab;

    public void Cast()
    {
        GameObject ps = Instantiate(particleSystemPrefab) as GameObject;
        //var main = ps.GetComponent<ParticleSystem>().main;
        ps.transform.position = transform.position;
        ps.GetComponent<ParticleSystem>().Play();
    }


}
