using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {

    //makes the variables and arrays it for multiple object use
    public GameObject[] planet;
    public GameObject[] blackHole;
    public float gravity = 30f;
    public float speed = 1;
    public float snapDistance = 0.7f;
    private bool grounded = true;
    public bool Grounded {  get { return grounded; } }


    private Rigidbody2D rig2d;
    Transform currentAttractor;

	// Use this for initialization
	void Start () {
        //gets the objects
        rig2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        planet = GameObject.FindGameObjectsWithTag("Planet");
        blackHole = GameObject.FindGameObjectsWithTag("BlackHole");
        //this is used for the planet gravity pull

        for (int i = 0; i < planet.Length; i++)
        {
            Vector2 offset = planet[i].transform.position - transform.position;
            
            float gravitysqr = offset.sqrMagnitude;

            if (gravitysqr > 0.001f && gravitysqr < 9)
            {
                if (currentAttractor == null)
                {
                    currentAttractor = planet[i].transform;
                }

                if (currentAttractor != planet[i].transform)
                {
                    rig2d.isKinematic = true;
                    print("Nieuwe Attractor");
                    transform.up = Vector3.Lerp(transform.up, -offset, speed * Time.deltaTime);

                    if (Vector3.Distance(transform.up, -offset) <= snapDistance)
                    {
                        currentAttractor = planet[i].transform;
                        print("snap");
                    }
                } else {
                    rig2d.isKinematic = false;
                    transform.up = -offset;
                    rig2d.AddForce(gravity * offset.normalized / gravitysqr);
                    grounded = true;
                }
            }
            
            else if(gravitysqr > 9)
                {
                    grounded = false;
                }
            
        }
        //this is used for the blackhole pull and range
        for (int i = 0; i < blackHole.Length; i++)
        {
            
            float gravity2 = 70;
            Vector2 offset2 = blackHole[i].transform.position - transform.position;

            float gravitysqr2 = offset2.sqrMagnitude;
            if (gravitysqr2 > 0.001f && gravitysqr2 < 100 && grounded == false)
            { 
                rig2d.AddForce(gravity2 * offset2.normalized / gravitysqr2);
            }
        }
        
    }

}
