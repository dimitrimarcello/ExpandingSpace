using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleMovement : MonoBehaviour {

    private Rigidbody2D blackHole;
    public float blackHoleSpeed = 10;
	// Use this for initialization
	void Start () {
        blackHole = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        blackHole.AddForce(Vector2.left * blackHoleSpeed);
    }
}
