using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneHandlerScript : MonoBehaviour
{
    private int level;
    ScoreScript Score;
    void Start()
    {
        Score = FindObjectOfType<ScoreScript>();        
        level = Score.CurrentLevel;
    }

    public void LoadMainMenuScene(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenuUIController");
    }
    public void LoadGameScene(){
        if(level==2){
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level2");
        }
        else if (level==3){
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level3");
        }
        else{            
            Score.SetScore(300);
            Score.SetLevel(1);
            Score.SetHP(3); 
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameController");
        }
    }
    public void LoadCustomizationScene(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("CustomizationUIController");
    }
    public void LoadSettingsScene(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("SettingsController");
    }
    public void LoadTutorialScreen(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("TutorialController");
    }
    public void LoadCredits(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Credits");
    }
}
