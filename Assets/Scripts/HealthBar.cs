using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image _healthBarFill;
    [SerializeField] public PlayerStats playerStats;
    private Camera _camera;
    void Awake()
    {
        playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
        _camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        _healthBarFill.fillAmount =(float) playerStats.currentHealth / playerStats.maxHealth;
        transform.LookAt(new Vector3(transform.position.x, _camera.transform.position.y, _camera.transform.position.z));
        transform.Rotate(0, 180, 0);
    }
}
