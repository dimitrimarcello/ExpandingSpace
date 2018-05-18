using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyerScript : MonoBehaviour {

    //SceneController controller;
    public GameObject[] obj;
    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.tag == "Player")
        {
            //Hier kan de gameover zijn
            SceneManager.LoadScene(1);
            return;
        }
        else if (other.tag == "Destroyer")
        {
            Debug.Log(" ");
            return;
        }
        else if(other.tag == "Planet")
        {
            Destroy(other.gameObject);
            BuildMap();
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
        Vector2 spawnLocation = new Vector2(transform.position.x + Random.Range(24, 27), 4 - Random.Range(1, 8));
        GameObject holes = Instantiate(obj[Random.Range(0, obj.GetLength(0))], spawnLocation, Quaternion.identity);
    }

}
