using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroScriptPlanet : MonoBehaviour
{

    //SceneController controller;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //Hier kan de gameover zijn
            SceneManager.LoadScene(2);
            return;
        }
        else if (other.tag == "Destroyer")
        {
            return;
        }
        else if (other.tag == "Planet")
        {
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

}
