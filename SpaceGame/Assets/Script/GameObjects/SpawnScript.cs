using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

    public GameObject[] obj;
    public float spawnMin = 1f;
    public float spawnMax = 2f;

    // Use this for initialization
    void Start () {
        Spawn();
	}
	
	void Spawn()
    {
        Vector2 spawnLocation = new Vector2(transform.position.x, transform.position.y - Random.Range(1, 8));
        GameObject holes = Instantiate(obj[Random.Range(0, obj.GetLength(0))], spawnLocation, Quaternion.identity);
        Invoke("Spawn", Random.Range(spawnMin, spawnMax));
    }
}
