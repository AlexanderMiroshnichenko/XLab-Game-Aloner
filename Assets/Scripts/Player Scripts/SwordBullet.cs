using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordBullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    [SerializeField] private LayerMask whatIsEnemy;
    [SerializeField] private Transform attackPoint;
    [SerializeField] private float attackRange;
    [SerializeField] private float damage;

    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * bulletSpeed;
        Destroy(gameObject, 4f);
    }
    private void Update()
    {
        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, whatIsEnemy);

        foreach (Collider enemy in hitEnemies)
        {
            Debug.Log("We hitted " + enemy.name);
            enemy.GetComponent<EnemyAI>().ApplyDamage(damage);
        }
    }
    // Update is called once per frame

}
