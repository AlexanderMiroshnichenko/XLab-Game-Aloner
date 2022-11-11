using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelBarFill : MonoBehaviour
{
    [SerializeField] private Image _levelBarFill;
    [SerializeField] PlayerStats playerStats;
    private Camera _camera;
    void Awake()
    {
        playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
        _camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        _levelBarFill.fillAmount = (float)playerStats.levelCurrentPoints / playerStats.levelPointsToReset;
       
    }
}
