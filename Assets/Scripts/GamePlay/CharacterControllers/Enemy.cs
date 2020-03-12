using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IEnemy
{
    private int health = 100;
    public int Health
    {
        get => health;
        set
        {
            health = value;
            if (health <= 0) gameObject.SetActive(false);
        }
    }
    public static List<GameObject> Enemies = new List<GameObject>();

    private void OnEnable()
    {
        Enemies.Add(gameObject);
        
    }

    private void OnDisable()
    {
        Enemies.Remove(gameObject);
    }

    public void TakeDamage(int amount)
    {
        Health -= amount;
    }

    public static GameObject GetRandomEnemy()
    {
        return Enemies[Random.Range(0, Enemies.Count)];
    }
}
