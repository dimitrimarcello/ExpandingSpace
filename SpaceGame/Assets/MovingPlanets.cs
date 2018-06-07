using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlanets : MonoBehaviour {

    private GameObject[] otherPlanets;
    private Transform closestPlanet;
    private Rigidbody2D thisPlanet;

    private void Start()
    {
        thisPlanet = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {
        otherPlanets = GameObject.FindGameObjectsWithTag("Planet");
        closestPlanet = otherPlanets[0].gameObject.GetComponent<Transform>();
    }
    void PlanetMovement()
    {
        thisPlanet.AddForce(Vector2.left * 1, 0);
    }
    void GetClosestPlanet()
    {

    }

}
