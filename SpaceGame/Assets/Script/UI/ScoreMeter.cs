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
    public Text highScoreLabel;
    private void Awake()
    {
        highScore = PlayerPrefs.GetFloat("HighScore", 0);
    }

    private void Update()
    {
        scorePlayer = Vector3.Distance(player.position, startDistance.position);
        scoreLabel.text = "Miles Travelled: " + scorePlayer;
        highScoreLabel.text = " HighScore: " + highScore;
        if(scorePlayer > highScore)
        {
            highScore = scorePlayer;
            highScoreLabel.text = " HighScore: " + highScore;

            PlayerPrefs.SetFloat("HighScore", highScore);
            PlayerPrefs.Save();
        }
    }

}
