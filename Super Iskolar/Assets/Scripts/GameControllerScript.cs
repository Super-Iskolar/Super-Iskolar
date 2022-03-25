using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    [SerializeField] GameObject GameOverMenu, GameInputUI;    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IskolarSpriteScript.playerHP <= 0){  
            GameInputUI.SetActive(false);                    
            GameOver();
        }
    }
    public void GameOver(){
        GameOverMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void MainMenu(){
        Time.timeScale = 1f;   
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenuUIController");
    }
}
