using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {

    public GameObject planet;
    public float gravity = 5.0f;

    private Rigidbody2D rig2d;

	// Use this for initialization
	void Start () {
        rig2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 offset = planet.transform.position - transform.position;

        float gravitysqr = offset.sqrMagnitude;

        if (gravitysqr > 0.001f)
        {
            rig2d.AddForce(gravity * offset.normalized / gravitysqr);
        }
    }
}
