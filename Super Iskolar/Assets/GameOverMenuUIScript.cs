using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMenuUIScript : MonoBehaviour
{    
    private int playerHP, scoreText, level;
    ScoreScript Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = FindObjectOfType<ScoreScript>();
        
        scoreText = Score.CurrentScore;
        level = Score.CurrentLevel;
        playerHP = Score.CurrentHP;
    }
    public void RESET(){
        Score.SetScore(300);
        Score.SetLevel(1);
        Score.SetHP(5);
    }
    
}
