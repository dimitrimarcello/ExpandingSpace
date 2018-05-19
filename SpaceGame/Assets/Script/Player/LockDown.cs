using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LockDown : MonoBehaviour {

    private Transform player;

    private void Awake()
    {
        player = GetComponent<Transform>();
    }
    private void Update()
    {
        if(player.position.x <= -10)
        {
            SceneManager.LoadScene(1);
            return;
        }
    }

}
