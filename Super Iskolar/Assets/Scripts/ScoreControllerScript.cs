using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControllerScript : MonoBehaviour
{
    public Text scoreTextUI, highscoreText;

    private int score, highscore;
   ScoreScript Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = FindObjectOfType<ScoreScript>();
        score = IskolarSpriteScript.scoreText;
        highscore = Score.HiScore;
        scoreTextUI.text = "SCORE: " + score.ToString();
        highscoreText.text = "HI-SCORE: " + highscore.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        score = IskolarSpriteScript.scoreText;   
        scoreTextUI.text = "SCORE: " + score.ToString();     
    }
}
