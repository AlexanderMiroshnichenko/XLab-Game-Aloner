using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerTurn : MonoBehaviour
{
    private Follower _follower;
    [SerializeField] private float _turningSpeed;
    private void Awake()
    {
        _follower = GetComponent<Follower>();
    }
    

    void FixedUpdate()
    {
        Quaternion currentPosition = Quaternion.Lerp(transform.rotation, _follower._playerPos.rotation, _turningSpeed * Time.fixedDeltaTime);

        transform.rotation = currentPosition;
    }
}
