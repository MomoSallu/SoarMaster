using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject GameOverScreen;
    public AudioSource gameSound;
    public AudioClip deathSound;
    public bool deathSoundPlayed = false; 

    [ContextMenu("Increase Score")]
    public void addScore(int scoreAddition) {
        playerScore += scoreAddition;
        scoreText.text = playerScore.ToString();
        gameSound.Play(); 
    }
    public void GameOver() { 
        GameOverScreen.SetActive(true);
        if (!deathSoundPlayed) {
            gameSound.PlayOneShot(deathSound);
            deathSoundPlayed = true;    
        }
    }
}
