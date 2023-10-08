using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUExtendUpController : MonoBehaviour
{
    public Collider2D ball;
    public float magnitude;
    public PowerUpManager manager;



    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball) 
        {
            ball.GetComponent<BallController>().ActivatePUSpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
