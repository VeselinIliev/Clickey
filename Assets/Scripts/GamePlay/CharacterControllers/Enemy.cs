using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IEnemy
{
    private int health = 100;
    public int Health { get => health; set => health = value; }

    public void TakeDamage(int amount)
    {
        Health -= amount;
    }

}
