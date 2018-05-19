using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {
    public GameObject startScheme;
    private void Awake()
    {
        Time.timeScale = 0;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Time.timeScale = 1;
            startScheme.SetActive(false);
            return;
        }
    }
}
