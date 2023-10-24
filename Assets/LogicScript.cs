using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public int highScore;
    public Text highScoreText;
    public Text scoreText;
    public GameObject GameOverScreen;
    public AudioSource gameSound;
    public AudioClip deathSound;
    public bool deathSoundPlayed = false;
    public Animator animator;

    void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    [ContextMenu("Increase Score")]
    public void addScore(int scoreAddition) {
        playerScore += scoreAddition;
        scoreText.text = playerScore.ToString();
        gameSound.Play(); 
    }
    public void GameOver() { 
        GameOverScreen.SetActive(true);
        if (playerScore > PlayerPrefs.GetInt("HighScore", 0)) {
            PlayerPrefs.SetInt("HighScore", playerScore);
            highScore = playerScore;
        }

        if (!deathSoundPlayed) {
            animator.SetBool("isDead", true);
            gameSound.PlayOneShot(deathSound);
            deathSoundPlayed = true;    
        }
        
        
    }
}
