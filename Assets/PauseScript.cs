using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject pause;
    public AudioSource song;

    // Start is called before the first frame update

    public void showOptionPanel()
    {
 
        pause.SetActive(true);
        Time.timeScale = 0;
        song.Pause();
    }

    public void Continue()
    {
        pause.SetActive(false);
        Time.timeScale = 1;
        song.UnPause();
    }
    
    public void Restart()
    {
        pause.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
         song.Play();
    }

    public void Home()
    {
        pause.SetActive(false);
        SceneManager.LoadSceneAsync(0);
        Time.timeScale = 1;
    }
}
