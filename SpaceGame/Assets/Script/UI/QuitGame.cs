using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour {

    private Button quit;

    private void Awake()
    {
        quit = GetComponent<Button>();
        quit.onClick.AddListener(Quit);
    }
    void Quit()
    {
        Application.Quit();
        Debug.Log(" ");
    }

}
