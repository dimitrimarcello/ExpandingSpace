using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    Rigidbody2D Player;
    public bool canJump = false;
    public float jetPackJump = 0.2f;
    public float jumpForceMedium = 3;
    public float jumpForceMax = 6f;
    public float playerSpeedLeft = -4f;
    public float playerSpeedRight = 4f;
    int temp = 1;
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
        else
        {
            return;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
        //if (Input.GetKey(KeyCode.UpArrow) && canJump == true)
        //{
            
        //    Player.AddForce((1 * jumpForceMax) * transform.up, ForceMode2D.Impulse);
        //    canJump = false;
        //    return;
        //}
        //if (Input.GetKey(KeyCode.DownArrow) && canJump == true)
        //{
        //    Player.AddForce((1 * jumpForceMedium) * transform.up, ForceMode2D.Impulse);
        //    canJump = false;
        //    return;
        //} 
        if(Input.GetKey(KeyCode.Space))
        {

            if (canJump == true)
            {
                Player.AddForce((17.5f * jetPackJump) * transform.up, ForceMode2D.Impulse);
                canJump = false;
            }
            else
            {
                Player.AddForce((1 * jetPackJump) * transform.up, ForceMode2D.Impulse);
            }
            return;
        }

    }
    public void RandomMove(string a)
    {
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
        }
        else
        {
            return;
        }
    }

}

