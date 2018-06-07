using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class start : MonoBehaviour
{

    public Button btn;

    // Use this for initialization
    void Start()
    {
        btn.onClick.AddListener(TaskOnClick);
    }

    private void TaskOnClick()
    {
<<<<<<< HEAD
        SceneManager.LoadScene("MainGame");
=======

        SceneManager.LoadScene("MainGame");

      
>>>>>>> d3afa4c2facaf53b2b9c34e9a8cc2e0645cb78ff

        //Initiate.Fade("MainGame", Color.black, 1.0f);
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //SceneManager.LoadScene("MainGame");
            SceneManager.LoadScene("MainGame");
        }

        
    }


}
