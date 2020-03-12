using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class Spell : MonoBehaviour, ISpell
{
    private SpellType spellType;
    public SpellType SpellType { get => spellType; set => spellType = value; }

    public int damage = 1;

    public float speed = 1;

    public GameObject particleSystemPrefab;
    public GameObject player;
    private GameObject spawned;
    public List<GameObject> enemies;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemies = GameObject.FindGameObjectsWithTag("Enemy").ToList();
    }

    public virtual void Cast()
    {
        spawned = Instantiate(particleSystemPrefab) as GameObject;
        //var main = ps.GetComponent<ParticleSystem>().main;
        spawned.transform.position = player.transform.position;
        spawned.GetComponent<HuntTarget>().target = GetRandomEnemy();
        spawned.GetComponent<HuntTarget>().speed = speed;
        spawned.GetComponent<HuntTarget>().damage = damage;
    }

    private GameObject GetRandomEnemy()
    {
        return enemies[Random.Range(0, enemies.Count)];
    }


}
