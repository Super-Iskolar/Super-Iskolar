using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerColliderScript : MonoBehaviour
{
    public Rigidbody2D player;
    private Vector3 respawnPoint;
    public GameObject fallDetector; // only if fallDetector changes position
    public GameObject VictoryUI, GameInputUI;
    
    private int playerHP, scoreText, level;
    ScoreScript Score;
    // Start is called before the first frame update
     Vector3 originalPos;
    void Start()
    {
        respawnPoint = player.transform.position; // spawn position of player is respawn point
        Score = FindObjectOfType<ScoreScript>();

        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        fallDetector.transform.position = new Vector2(player.transform.position.x, fallDetector.transform.position.y);
        //for changing of fallDetector position if necessary
    }
    
    // detect fall method, additional life pickup (run when player enters collider of object)
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "FallDetector" || collision.tag == "BlueBookEnemy")
        {
            player.transform.position = respawnPoint;
            IskolarSpriteScript.playerHP = IskolarSpriteScript.playerHP - 1;
        }
        
        if(collision.tag == "PickUpLife")
        {
            Destroy(collision.gameObject);
            if(IskolarSpriteScript.playerHP != 3){
                IskolarSpriteScript.playerHP = IskolarSpriteScript.playerHP + 1;
            }
        }

        if(collision.tag == "Collectible1" || collision.tag == "Collectible2" || collision.tag == "Collectible3")
        {
            Destroy(collision.gameObject);

            if(collision.tag == "Collectible1")
            {
                CollectibleScript.Costume1Status = true;
                UpdateCollectibleScript.C1found = true;
            }
            else if(collision.tag == "Collectible2")
            {
                CollectibleScript.Costume2Status = true;
                UpdateCollectibleScript.C2found = true;
            }
            else if(collision.tag == "Collectible3")
            {
                CollectibleScript.Costume3Status = true;
                UpdateCollectibleScript.C3found = true;
            }

        }
        
        if(collision.tag == "GoalLevel1")
        {
            Time.timeScale = 1f;
            Score.SetScore(IskolarSpriteScript.scoreText);
            Score.SetLevel(2);
            Score.SetHP(IskolarSpriteScript.playerHP);   
            Time.timeScale = 0f;
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level2");
        }        
        if(collision.tag == "GoalLevel2")
        {
            Time.timeScale = 1f;   
            Score.SetScore(IskolarSpriteScript.scoreText);
            Score.SetLevel(3);
            Score.SetHP(IskolarSpriteScript.playerHP); 
            Time.timeScale = 0f;
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level3");
        }
        if(collision.tag == "GoalLevel3")
        {
            Time.timeScale = 1f;   
            GameInputUI.SetActive(false);
            VictoryUI.SetActive(true);
            Time.timeScale = 0f;
            Score.SetScore(IskolarSpriteScript.scoreText);
            Score.SetLevel(1);
            Score.SetHP(IskolarSpriteScript.playerHP); 
        }
    }
    
    public void ResetPosition(){
        player.transform.position = originalPos;
    }
}
