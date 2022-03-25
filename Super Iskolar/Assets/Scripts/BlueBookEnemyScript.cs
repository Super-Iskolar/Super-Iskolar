using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBookEnemyScript : MonoBehaviour
{
    public int bluebookhealth;
    
    // Start is called before the first frame update
    void Start()
    {
        bluebookhealth = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag != "Player")
        {
            Destroy(collision.gameObject);
            bluebookhealth = bluebookhealth - 1;
            if(bluebookhealth == 0)
            {
                Destroy(gameObject);
            }
        }
    }
    
}
