using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IskolarSpriteScript : MonoBehaviour
{
    public static int playerHP;
    // Start is called before the first frame update
    void Start()
    {
    playerHP = 3;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHP > 3){                      // sets the maximum lives to 3
            playerHP = 3;
        }

    }
}
