using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateCollectibleScript : MonoBehaviour
{
    private GameObject[] C1;
    private GameObject[] C2;
    private GameObject[] C3;
    public static bool C1found;
    public static bool C2found;
    public static bool C3found;

    // Start is called before the first frame update
    void Start()
    {
        C1 = GameObject.FindGameObjectsWithTag("Collectible1");
        C2 = GameObject.FindGameObjectsWithTag("Collectible2");
        C3 = GameObject.FindGameObjectsWithTag("Collectible3");
    }

    // Update is called once per frame
    void Update()
    {
        if (C1found == true)
        {
            foreach (GameObject c in C1)
            {
                c.SetActive(false);
            }
        }
        if (C2found == true)
        {
            foreach (GameObject c in C2)
            {
                c.SetActive(false);
            }
        }
        if (C3found == true)
        {
            foreach (GameObject c in C3)
            {
                c.SetActive(false);
            }
        }
    }
}
