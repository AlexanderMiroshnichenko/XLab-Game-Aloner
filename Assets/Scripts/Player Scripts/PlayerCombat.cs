using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : IAttacking
{
    [SerializeField] private Transform _attackPoint;
    [SerializeField] private LayerMask _whatIsEnemy;
    [SerializeField] private float _damage;
    [SerializeField] private float _timeBetweenAttacks;
    [SerializeField] private float _attackRange;

    // Update is called once per frame
    private void FixedUpdate()
    {
        Attack(_damage,_timeBetweenAttacks,_attackRange,_whatIsEnemy);
     
    }
    
        void OnDrawGizmosSelected()
        {
            if (_attackPoint == null) return;
            Gizmos.DrawWireSphere(_attackPoint.position, _attackRange);
        }
  
}



