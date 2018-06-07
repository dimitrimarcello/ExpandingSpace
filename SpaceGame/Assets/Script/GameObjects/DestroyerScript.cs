using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyerScript : MonoBehaviour {

    //SceneController controller;
    public GameObject[] obj;
    public GameObject imageWarning;
    public Transform planetSpawner;
    private bool corect;
    float _planetSpawner;
    private void Update()
    {
        _planetSpawner = planetSpawner.position.x;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("gameOver");
            return;
        }
        else if (other.gameObject.tag == "Destroyer")
        {
            return;
        }
        else if(other.gameObject.tag == "Planet")
        {
            Destroy(other.gameObject);
            corect = true;
            BuildMap();
            return;

        }
        else if(other.gameObject.tag == "BlackHole")
        {
            imageWarning.SetActive(false);
            Destroy(other.gameObject);
            return;
        }
        if (other.gameObject.transform.parent)
        {
            Destroy(other.gameObject.transform.parent.gameObject);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
    public void BuildMap()
    {
        if(corect == true)
        {
            Vector2 spawnLocation = new Vector2(_planetSpawner, 4 - Random.Range(1, 8));
            GameObject holes = Instantiate(obj[Random.Range(0, obj.GetLength(0))], spawnLocation, Quaternion.identity);
            corect = false;
            return;
        }
        else
        {
            return;
        }
        
    }

}
