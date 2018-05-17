using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    Rigidbody2D Player;
    public bool canJump = false;
    public float jumpForceSmall = 10;    
    public float jumpForceMedium = 2;
    public float jumpForceMax = 2.5f;
    Quaternion zeroRotation;



    private void Awake()
    {
        Player = GetComponent<Rigidbody2D>();
    }

    public void RotateRight()
    {
        Player.AddTorque(0.25f);
    }
    public void RotateLeft()
    {
        Player.AddTorque(-0.25f);
    }
    public void RotateUp()
    {
        Player.AddTorque(0.5f);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Planet")
        {
            canJump = true;
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
        if (Input.GetButtonDown("space"))
        {
            if (canJump == true)
            {
                // Jump on ridigbody
                Player.AddForce(jumpForceSmall * transform.up, ForceMode2D.Impulse);
                canJump = false;
            }
        }
        if (Input.GetButtonDown("ArrowUp") && canJump == true)
        {
            Player.AddForce((jumpForceSmall * jumpForceMax) * transform.up, ForceMode2D.Impulse);
            canJump = false;
        }
        if (Input.GetButtonDown("ArrowDown") && canJump == true)
        {
            Player.AddForce((jumpForceSmall * jumpForceMedium) * transform.up, ForceMode2D.Impulse);
            canJump = false;
        }
    }
}

