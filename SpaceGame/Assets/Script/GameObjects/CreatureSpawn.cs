using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureSpawn : MonoBehaviour {
    public GameObject[] creatures;

    private void Awake()
    {
        SpawnCreatures();
    }
    void SpawnCreatures() {
        Vector2 spawnLocation = new Vector2(transform.position.x, transform.position.y + 1);
        GameObject holes = Instantiate(creatures[Random.Range(0, creatures.GetLength(0))], spawnLocation, Quaternion.identity);
    }
}
