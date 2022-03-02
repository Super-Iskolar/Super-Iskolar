using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneHandlerScript : MonoBehaviour
{
    public void LoadMainMenuScene(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenuUIController");
    }
    public void LoadGameScene(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameController");
    }
    public void LoadCustomizationScene(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("CustomizationUIController");
    }
    public void LoadSettingsScene(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("SettingsController");
    }
}
