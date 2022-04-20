using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerColliderScript : MonoBehaviour
{
    public Rigidbody2D player;
    private Vector3 respawnPoint;
    public GameObject fallDetector; // only if fallDetector changes position
    
    // Start is called before the first frame update
    void Start()
    {
        respawnPoint = player.transform.position; // spawn position of player is respawn point
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

        if(collision.tag == "Collectible")
        {
            Destroy(collision.gameObject);
        }
        
        if(collision.tag == "GoalLevel1")
        {
            Time.timeScale = 1f;   
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level2");
        }
        
        if(collision.tag == "GoalLevel2")
        {
            Time.timeScale = 1f;   
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level3");
        }
        if(collision.tag == "GoalLevel3")
        {
            Time.timeScale = 1f;   
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        }
    }
    
}
