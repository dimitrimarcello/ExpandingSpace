using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    Rigidbody2D Player;
    public float playerSpeedLeft = -4f;
    Quaternion zeroRotation;



    private void Awake()
    {
        Player = GetComponent<Rigidbody2D>();
        RandomMove("Enable");
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Planet")
        {
            RandomMove("Enable");
            return;
        }
        else
        {
            return;
        }
    }
    public void RandomMove(string a)
    {
        if (a == "Enable")
        {
                Player.velocity = -transform.right * playerSpeedLeft;
        }
        else
        {
            return;
        }
    }

}

