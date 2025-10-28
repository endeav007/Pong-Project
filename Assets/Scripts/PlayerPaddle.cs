using System;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;

    // fucntion called every frame update
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _direction = Vector2.up;
           
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _direction = Vector2.down;
        }
        else
        {
            //when a key isn't pressed, we're not moving
            _direction = Vector2.zero;
        } 

    }

// Called at a fixed time interval. Associated with physics to keep them consistne.t Physics related code goes in here. 
    private void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0)
        {
            _rigidbody.AddForce(_direction * this.speed);
        }
    }
}
