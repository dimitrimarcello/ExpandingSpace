using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSideCollsionLeft : MonoBehaviour {
    PlayerMovement a = new PlayerMovement();
    private void OnCollisionStay2D(Collision2D checkSide)
    {
        if (checkSide.gameObject.tag == "Planet")
            a.RotateRight();
         
    }

}
