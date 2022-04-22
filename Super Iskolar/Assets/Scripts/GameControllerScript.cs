using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    [SerializeField] GameObject GameOverMenu, GameInputUI, PauseMenu;    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(time());
        Time.timeScale = 1f;   
    }

    // Update is called once per frame  
    void Update()
    {
        if (IskolarSpriteScript.playerHP <= 0){  
            GameInputUI.SetActive(false);                    
            GameOver();
        }
    }
     IEnumerator time(){
        while (true)
        {
            timeCount();
            yield return new WaitForSeconds(1);
        }
    }
    public void GameOver(){
        PauseMenu.SetActive(false);
        GameOverMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void MainMenu(){
        Time.timeScale = 1f;   
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenuUIController");
    } 
    void timeCount(){
     IskolarSpriteScript.scoreText -= 1;
    }
}
