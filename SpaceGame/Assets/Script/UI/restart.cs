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
        SceneManager.LoadScene("MainGame");
    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //SceneManager.LoadScene("MainGame");
            SceneManager.LoadScene("MainGame");
        }

        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                SceneManager.LoadScene("MainGame");
            }
        }
    }

}
