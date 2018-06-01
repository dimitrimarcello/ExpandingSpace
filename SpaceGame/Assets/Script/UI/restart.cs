using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class restart : MonoBehaviour {

    public Button btn;

	// Use this for initialization
	void Start () {
        btn.onClick.AddListener(TaskOnClick);
    }
	
    private void TaskOnClick()
    {
        //SceneManager.LoadScene("MainGame");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //SceneManager.LoadScene("MainGame");
            Initiate.Fade("MainGame", Color.black, 1.0f);
        }

        if (Input.GetButton("Fire1"))
        {
            //SceneManager.LoadScene("MainGame");
            Initiate.Fade("MainGame", Color.black, 1.0f);
        }
    }

}
