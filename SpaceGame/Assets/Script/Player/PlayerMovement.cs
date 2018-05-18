using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    Rigidbody2D Player;
    public bool canJump = false; 
    public float jumpForceMedium = 3;
    public float jumpForceMax = 6f;
    public float playerSpeedLeft = -0.5f;
    public float playerSpeedRight = 0.5f;
    Quaternion zeroRotation;



    private void Awake()
    {
        Player = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if(other.gameObject.tag == "Planet")
        {
            if(canJump == false)
            {
                canJump = true;
            }  
            RandomMove("Enable");
            return;
        }
        if(other.gameObject.tag == "BlackHole" && canJump == false)
        {
            Debug.Break();
            return;
        }
        else
        {
            return;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && canJump == true)
        {
            Player.AddForce((1 * jumpForceMax) * transform.up, ForceMode2D.Impulse);
            canJump = false;
            return;
        }
        if (Input.GetKey(KeyCode.DownArrow) && canJump == true)
        {
            Player.AddForce((1 * jumpForceMedium) * transform.up, ForceMode2D.Impulse);
            canJump = false;
            return;
        }
    }
    public void RandomMove(string a)
    {
        int temp = Random.Range(1, 2);
        if(a == "Enable")
        {
            if(temp == 1)
            {
                Player.velocity = -transform.right * playerSpeedLeft;
            }
            else if(temp == 2)
            {
                Player.velocity = -transform.right * playerSpeedRight;
            }
        }if(a == "Disable")
        {
            Player.velocity = -transform.right * 0;
        }
        else
        {
            return;
        }
    }
}

