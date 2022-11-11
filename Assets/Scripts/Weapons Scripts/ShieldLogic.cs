using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldLogic : IAttacking
{ private bool _alreadyAttacked;

    [SerializeField] private float _shieldDamage;
    [SerializeField] private float _shieldTimeBetweenAttacks;
    [SerializeField] private float _shieldAttackRange;
    [SerializeField] private LayerMask _whatIsEnemy;
    private void Update()
    {
        Attack(_shieldDamage, _shieldTimeBetweenAttacks, _shieldAttackRange, _whatIsEnemy);
    }
   
    void OnDrawGizmosSelected()
    {
        if (transform.position == null) return;
        Gizmos.DrawWireSphere(transform.position, _shieldAttackRange);
    }
}
