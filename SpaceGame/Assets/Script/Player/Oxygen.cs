using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Oxygen : MonoBehaviour {

    private float oxygenTime = 50;
    private float roundUp;
    //public Text oxygenDisplay;
    public Slider timerSlide;


    private void Update()
    {
        timerSlide.value = oxygenTime;
        roundUp = Mathf.Round(oxygenTime);
        //oxygenDisplay.text = "Oxygen Left:" + roundUp;
        oxygenTime -= Time.deltaTime;
        Debug.Log(oxygenTime);
        if(oxygenTime <= 0)
        {
            SceneManager.LoadScene("gameOver");
            return;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Oxygen")
        {
            if(oxygenTime <= 30)
            {
                Destroy(collision.gameObject);
                oxygenTime = 30;
                return;
            }
            if(oxygenTime > 30 && oxygenTime < 40)
            {
                Destroy(collision.gameObject);
                oxygenTime = 40;
                return;
            }
            if(oxygenTime > 40 && oxygenTime < 50)
            {
                oxygenTime = 50;
                Destroy(collision.gameObject);
                return;
            }
        }
        if(collision.gameObject.tag == "Oxygen Special")
        {
            Destroy(collision.gameObject);
            oxygenTime = 50;
            return;
        }
        else
        {
            return;
        }
    }

}
