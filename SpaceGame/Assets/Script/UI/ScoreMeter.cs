using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMeter : MonoBehaviour {

    public float scorePlayer;
    public float highScore;
    public Transform startDistance;
    public Transform player;
    public Text scoreLabel;

    private void Update()
    {
        scorePlayer = Vector3.Distance(player.position, startDistance.position);
        scoreLabel.text = "Miles Travelled: " + scorePlayer;
    }

}
