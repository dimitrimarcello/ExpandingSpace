using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{

    private Button pauseButton;
    public GameObject imagePause;
    private bool checkPause = false;

    private void Start()
    {
        imagePause.SetActive(false);
        pauseButton = GetComponent<Button>();
        pauseButton.onClick.AddListener(Pausegame);
    }
    void Pausegame()
    {
        if (checkPause == false)
        {
            Time.timeScale = 0;
            imagePause.SetActive(true);
            checkPause = true;
        }
        else if (checkPause == true)
        {
            Time.timeScale = 1;
            imagePause.SetActive(false);
            checkPause = false;
        }
    }
        void FixedUpdate()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (checkPause == false)
                {
                    Time.timeScale = 0;
                    imagePause.SetActive(true);
                    checkPause = true;
                }
                else if (checkPause == true)
                {
                    Time.timeScale = 1;
                    imagePause.SetActive(false);
                    checkPause = false;
                }
            }
        }
}

