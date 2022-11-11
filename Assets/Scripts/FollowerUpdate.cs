using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerUpdate : Follower
{
    private GameObject _player;
    private void Awake()
    {
        _player = GameObject.Find("Player");
    }

    private void Update()
    {
        Move(Time.deltaTime);
        DieCheck();
        
    }
    private void DieCheck()
    {
        if (_player == null)
        {
            Destroy(gameObject);
        }
    }
}
