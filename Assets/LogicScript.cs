using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject GameOverScreen;
    public AudioSource scoreSound;
    public AudioSource deathSound;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreAddition) {
        playerScore += scoreAddition;
        scoreText.text = playerScore.ToString();
        scoreSound.Play();  
    }
    public void GameOver() { 
        GameOverScreen.SetActive(true);
        deathSound.Play();
    }
}
