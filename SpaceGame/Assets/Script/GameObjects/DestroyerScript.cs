using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyerScript : MonoBehaviour {

    //SceneController controller;
    public GameObject[] obj;
    public GameObject imageWarning;
    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.tag == "Player")
        {
            SceneManager.LoadScene(2);
            return;
        }
        else if (other.tag == "Destroyer")
        {
            return;
        }
        else if(other.tag == "Planet")
        {
            Destroy(other.gameObject);
            BuildMap();
            return;

        }
        else if(other.tag == "BlackHole")
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
        Vector2 spawnLocation = new Vector2(transform.position.x + Random.Range(24, 25), 4 - Random.Range(1, 8));
        GameObject holes = Instantiate(obj[Random.Range(0, obj.GetLength(0))], spawnLocation, Quaternion.identity);
    }

}
