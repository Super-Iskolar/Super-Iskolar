using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    public static bool Costume1Status;
    public static bool Costume2Status;
    public static bool Costume3Status;

    public GameObject Costume1;
    public GameObject Costume2;
    public GameObject Costume3;

    public GameObject arrows1;
    public GameObject arrows2;
    public GameObject arrows3;

    // Start is called before the first frame update
    void Start()
    {

        if (CollectibleScript.Costume1Status == false)
        {
            Costume1.SetActive(false);
        }
        else {
            if (arrows1.activeSelf == true)
            {
                Costume1.SetActive(true);
            }
            else
            {
                Costume1.SetActive(false);
            }
        }

        if (CollectibleScript.Costume2Status == false)
        {
            Costume2.SetActive(false);
        }
        else {
            if (arrows2.activeSelf == true)
            {
                Costume2.SetActive(true);
            }
            else
            {
                Costume2.SetActive(false);
            }
        }

        if (CollectibleScript.Costume3Status == false)
        {
            Costume3.SetActive(false);
        }
        else {
            if (arrows3.activeSelf == true)
            {
                Costume3.SetActive(true);
            }
            else
            {
                Costume3.SetActive(false);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (CollectibleScript.Costume1Status == false)
        {
            Costume1.SetActive(false);
        }
        else {
            if (arrows1.activeSelf == true)
            {
                Costume1.SetActive(true);
            }
            else
            {
                Costume1.SetActive(false);
            }
        }

        if (CollectibleScript.Costume2Status == false)
        {
            Costume2.SetActive(false);
        }
        else {
            if (arrows2.activeSelf == true)
            {
                Costume2.SetActive(true);
            }
            else
            {
                Costume2.SetActive(false);
            }
        }

        if (CollectibleScript.Costume3Status == false)
        {
            Costume3.SetActive(false);
        }
        else {
            if (arrows3.activeSelf == true)
            {
                Costume3.SetActive(true);
            }
            else
            {
                Costume3.SetActive(false);
            }
        }

    }
}
