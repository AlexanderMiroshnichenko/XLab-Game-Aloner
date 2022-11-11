using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelNumber : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    [SerializeField] public PlayerStats playerStats;
    private void Start()
    {
        playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = playerStats.level+"";
    }
}
