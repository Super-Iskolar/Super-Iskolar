using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGameScene : MonoBehaviour
{
    public void button_change(string Scene_name){
        UnityEngine.SceneManagement.SceneManager.LoadScene(Scene_name);
    }
}
