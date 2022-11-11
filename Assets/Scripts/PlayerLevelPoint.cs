using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevelPoint : MonoBehaviour
{
  [SerializeField] private float _pickRadius;
  [SerializeField]  private LayerMask _whatIsPlayer;
  [SerializeField] private float _levelPointAmount;
    private bool _isPlayerPicked;
    public PlayerStats playerStats;

    void Start()
    {
        playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
          _isPlayerPicked = Physics.CheckSphere(transform.position, _pickRadius, _whatIsPlayer);
        if (_isPlayerPicked)
        {
            playerStats.levelCurrentPoints += _levelPointAmount;
            Destroy(gameObject);
            
        }

    }
    void OnDrawGizmosSelected()
    {
        if (transform == null) return;
        Gizmos.DrawWireSphere(transform.position, _pickRadius);
    }
}
