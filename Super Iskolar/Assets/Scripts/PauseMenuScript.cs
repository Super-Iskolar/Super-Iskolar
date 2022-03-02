using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenuScript : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    // Start is called before the first frame update
    public void Pause(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;        
    }
    public void MainMenu(){
        Time.timeScale = 1f;   
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenuUIController");
    }
}
