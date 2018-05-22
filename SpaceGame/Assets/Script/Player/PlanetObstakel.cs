using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlanetObstakel : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("gameOver");
            return;
        }
        else if(collision.gameObject.tag == "Planet")
        {
            return;
        }
        else
        {
            return;
        }
    }
}
