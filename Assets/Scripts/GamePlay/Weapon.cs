using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public int damage = 0;
    public bool isRanged = false;
    public float range = 1;
    public float attackSpeed = 1;
    public float attackCooldown = 0;

    void Start()
    {
        
    }

    void Update()
    {
        attackCooldown += Time.deltaTime;
    }

    public virtual void Attack(IAttackable target)
    {
        target.TakeDamage(damage);
        RessAttackTimer();
    }

    public void RessAttackTimer()
    {
        attackCooldown = 0;
    }

    public int GetDamage()
    {
        return damage;
    }

    public bool CanAttack()
    {
        return (attackSpeed<attackCooldown);
    }

}
