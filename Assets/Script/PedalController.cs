using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedalController : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    public KeyCode upKey;
    public KeyCode downKey;
    
    private Rigidbody2D rig;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 movement = GetInput();
        MoveObject(movement);
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey)) 
        {
            return Vector2.up * _speed;
        }
        else if (Input.GetKey(downKey)) 
        {
            return Vector2.down * _speed;
        }
        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        rig.velocity = movement;
    }

}
