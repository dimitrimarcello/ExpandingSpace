using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnScript : MonoBehaviour {

    public GameObject[] obj1;
    public Transform _player;
    public float spawnMin = 20;
    public float spawnMax = 40;
    private float playerRange;
    public GameObject warning;
    bool doIt = true;
    // Use this for initialization
    void Start () {
        warning.SetActive(false);
        playerRange = _player.position.x + 40;
	}
    private void FixedUpdate()
    {
        if(_player.position.x >= playerRange && doIt == true)
        {
           Spawn();
        }
    }
    void Spawn() {
        warning.SetActive(true);
        Vector3 spawnLocation = new Vector3(transform.position.x, transform.position.y - Random.Range(1, 8), -4f);
        GameObject holes = Instantiate(obj1[Random.Range(0, obj1.GetLength(0))], spawnLocation, Quaternion.identity);
        Invoke("Spawn", Random.Range(spawnMin, spawnMax));
        doIt = false;
                
    }

}
