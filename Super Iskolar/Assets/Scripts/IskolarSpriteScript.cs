using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IskolarSpriteScript : MonoBehaviour
{
    public static int playerHP, scoreText, level;
    ScoreScript Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = FindObjectOfType<ScoreScript>();
        
        scoreText = Score.CurrentScore;
        level = Score.CurrentLevel;
        playerHP = Score.CurrentHP;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHP > 3){                      // sets the maximum lives to 3
            playerHP = 3;
        }
        if (playerHP <= 0){                      // sets the minimum lives to 0
            playerHP = 0;
        }
    }
}
