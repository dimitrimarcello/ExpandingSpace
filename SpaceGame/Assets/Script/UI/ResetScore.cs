using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScore : MonoBehaviour {
    private bool R = false;
    private bool E = false;
    private bool S = false;
    private bool T = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            R = true;
            return;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            E = true;
            return;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            S = true;
            return;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            T = true;
            return;
        }if(R == true && E == true && S == true && T == true)
        {
            PlayerPrefs.DeleteAll();
            Debug.Log("deleted highscores");
            return;
        }
    }
}
