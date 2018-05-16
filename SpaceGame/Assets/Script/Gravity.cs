using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {

    public GameObject[] planet;
    public float gravity = 30f;

    private Rigidbody2D rig2d;

	// Use this for initialization
	void Start () {
        rig2d = GetComponent<Rigidbody2D>();
        planet = GameObject.FindGameObjectsWithTag("Planet");
    }
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < planet.Length; i++)
        {
            Vector2 offset = planet[i].transform.position - transform.position;

            float gravitysqr = offset.sqrMagnitude;

            if (gravitysqr > 0.001f && gravitysqr < 15)
            {
                rig2d.AddForce(gravity * offset.normalized / gravitysqr);
            }
        }
    }
}
