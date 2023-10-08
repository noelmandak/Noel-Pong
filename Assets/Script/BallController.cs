using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private Vector2 _speed;
    public Vector2 resetPosition;

    private Rigidbody2D rig;
    

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity =  _speed;
    }

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 9) ;
        rig.velocity =  _speed;
    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rig. velocity *= magnitude;
    }
}
