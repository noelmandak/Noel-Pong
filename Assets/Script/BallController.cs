using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private Vector2 _speed;
    private Rigidbody2D rig;
    

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity =  _speed;
    }

    void Update()
    {
    }
}
