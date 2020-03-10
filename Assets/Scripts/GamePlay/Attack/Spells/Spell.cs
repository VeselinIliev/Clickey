using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell : MonoBehaviour, ISpell
{
    private SpellType spellType;
    public SpellType SpellType { get => spellType; set => spellType = value; }

    public GameObject particleSystemPrefab;

    public void Cast()
    {
        GameObject ps = Instantiate(particleSystemPrefab) as GameObject;
        ps.transform.position = transform.position;
        ps.GetComponent<ParticleSystem>().Play();
    }

}
