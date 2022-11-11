using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IAttacking : MonoBehaviour
{
    bool alreadyAttacked=false;
   public void Attack(float damage, float timeBetweenAttacks, float attackRange, LayerMask whatIsEnemy )
    {
        if (!alreadyAttacked)
        {
            Collider[] hitEnemies = Physics.OverlapSphere(transform.position, attackRange, whatIsEnemy);

            foreach (Collider enemy in hitEnemies)
            {
                Debug.Log("We hitted " + enemy.name);
                enemy.GetComponent<EnemyAI>().ApplyDamage(damage);
            }

            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }

    private void ResetAttack()
    {
        alreadyAttacked = false;
    }
}
