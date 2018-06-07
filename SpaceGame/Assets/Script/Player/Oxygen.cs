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
    public Animator oxygen;
    public Animator oxygenSpecial;

    private void FixedUpdate()
    {
        timerSlide.value = oxygenTime;
        roundUp = Mathf.Round(oxygenTime);
        //oxygenDisplay.text = "Oxygen Left:" + roundUp;
        oxygenTime -= Time.deltaTime;
       
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
            oxygen = collision.gameObject.GetComponent<Animator>();
            oxygen.Play("Oxygen");
            if(oxygenTime <= 30)
            {
                Destroy(collision.gameObject, 0.3f);
                oxygenTime = 30;
                return;
            }
            if(oxygenTime > 30 && oxygenTime < 40)
            {
                Destroy(collision.gameObject, 0.3f);
                oxygenTime = 40;
                return;
            }
            if(oxygenTime > 40 && oxygenTime < 50)
            {
                oxygenTime = 50;
                Destroy(collision.gameObject, 0.3f);
                return;
            }
        }
        if(collision.gameObject.tag == "Oxygen Special")
        {
            oxygenSpecial = collision.gameObject.GetComponent<Animator>();
            Destroy(collision.gameObject, 0.3f);
            oxygenSpecial.Play("Oxygen");
            oxygenTime = 50;
            return;
        }
        else
        {
            return;
        }
    }

}
