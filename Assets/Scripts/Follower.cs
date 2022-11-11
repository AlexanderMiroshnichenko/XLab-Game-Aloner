using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public Transform _playerPos;
    private Vector3 _target;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _trackingSpeed;

    private void Awake()
    {
        _playerPos = GameObject.Find("Player").transform;
    }



    private protected void Move(float deltaTime)
    {
        if (_playerPos)
        {
            Vector3 currentPosition = Vector3.Lerp(transform.position, _target, _trackingSpeed*deltaTime);
            transform.position = currentPosition;

            _target = new Vector3(_playerPos.transform.position.x, _playerPos.position.y, _playerPos.position.z) + _offset;
        }
    }
}
