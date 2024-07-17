using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource song;
  
   


    [ContextMenu("Increase Score")]
    public void addScore(int scoreTOAdd)
    {
        playerScore = playerScore + scoreTOAdd;
        scoreText.text = playerScore.ToString();
        song.Play();
    }
    
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

}

