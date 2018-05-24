using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    private Transform planet;

    private void Awake()
    {
        planet = GetComponent<Transform>();
        
    }
    private void Update()
    {
        planet.Rotate(Vector3.right * Time.deltaTime);
    }


}
