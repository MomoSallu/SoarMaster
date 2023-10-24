using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
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
    public void highScoreCheck() {
        if (playerScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", playerScore);
            highScoreText.text = playerScore.ToString();
        }
    }
    public void addScore(int scoreAddition) {
        playerScore += scoreAddition;
        scoreText.text = playerScore.ToString();
        gameSound.Play();
        highScoreCheck();
    }
    public void GameOver() { 
        GameOverScreen.SetActive(true);
        highScoreCheck() ;  
        if (!deathSoundPlayed) {
            animator.SetBool("isDead", true);
            gameSound.PlayOneShot(deathSound);
            deathSoundPlayed = true;    
        }
        
        
    }
}
