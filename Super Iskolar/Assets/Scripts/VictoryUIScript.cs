using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryUIScript : MonoBehaviour
{
    private int scoreText, oldHiScore;
    ScoreScript Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = FindObjectOfType<ScoreScript>();
        
        scoreText = Score.CurrentScore;
        oldHiScore = Score.HiScore;
    }
    void Update()
    {
        scoreText = IskolarSpriteScript.scoreText;     
    }
    public void StoreWin(){
        if (scoreText>oldHiScore){
            Score.SetHiScore(scoreText);
        }
        
        // PlayerPrefs.DeleteAll();
        // PlayerPrefs.Save();
    }
}
