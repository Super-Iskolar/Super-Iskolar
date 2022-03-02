using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOTOCustomize : MonoBehaviour
{
    public void button_change2(string Scene_name){
        UnityEngine.SceneManagement.SceneManager.LoadScene(Scene_name);
    }
}
