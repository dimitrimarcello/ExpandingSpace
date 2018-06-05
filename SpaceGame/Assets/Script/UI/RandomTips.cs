using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTips : MonoBehaviour {

    public GameObject[] tips;

    private void Start()
    {
        for(int i = 0; i < tips.Length; i++)
        {
            tips[i].SetActive(false);
        }
        int random = Random.Range(0, tips.Length);
        tips[random].SetActive(true);
    }
}
