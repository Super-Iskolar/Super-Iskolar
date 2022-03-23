using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesGUIScript : MonoBehaviour
{    
    private int playerHP;
    public List<GameObject> livesGUIHearts = new List<GameObject>();
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        playerHP = IskolarSpriteScript.playerHP;
        livesGUIHearts[playerHP].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {   
        playerHP = IskolarSpriteScript.playerHP;
        while (count<=3){                           // Makes appropriate lives heart visible
            if(count==playerHP){
                livesGUIHearts[playerHP].SetActive(true);
            }
            else {
                livesGUIHearts[count].SetActive(false);
            }
            count += 1;
        }
        count = 0;
    }
}
