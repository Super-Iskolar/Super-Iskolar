using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    string key = "Score";
    string levelKey = "playerLevel";
    string HPkey = "playerHP";
    string hiScorekey = "HiScore";

    public int CurrentScore {get; set;}
    public int CurrentLevel {get; set;}
    public int CurrentHP {get; set;}
    public int HiScore {get; set;}


    private void Awake(){
        CurrentScore = PlayerPrefs.GetInt(key, 300);
        CurrentLevel = PlayerPrefs.GetInt(levelKey, 1);
        CurrentHP = PlayerPrefs.GetInt(HPkey, 3);
        HiScore = PlayerPrefs.GetInt(hiScorekey, 0);
    }

    public void SetScore(int score){
        PlayerPrefs.SetInt(key, score);
    }
    public void SetLevel(int score){
        PlayerPrefs.SetInt(levelKey, score);
    }
    public void SetHP(int score){
        PlayerPrefs.SetInt(HPkey, score);
    }    
    public void SetHiScore(int score){
        PlayerPrefs.SetInt(hiScorekey, score);
    }
}
