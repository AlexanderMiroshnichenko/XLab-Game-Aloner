using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats :  MonoBehaviour,IDamageable
{
    public float maxHealth;
    public float currentHealth;
    public float level=0;
    public float levelCurrentPoints=0;
    public float levelPointsToReset = 100;


    private void Start()
    {
        currentHealth = maxHealth;
    }
    private void Update()
    {
        MoveToNextLevel();
    }
    public void ApplyDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0) Invoke(nameof(DestroyEnemy), 0.5f);
    }
    private void DestroyEnemy()
    {
        Destroy(gameObject);
    }
    
    private void MoveToNextLevel()
    {
        if (levelCurrentPoints >= levelPointsToReset)
        {
            level++;
            levelCurrentPoints = 0;
        }
    }
}
