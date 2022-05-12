using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCostumeScript : MonoBehaviour
{
    public static int CurrentCostume;

    public GameObject Select1;
    public GameObject Selected1;
    public GameObject Select2;
    public GameObject Selected2;
    public GameObject Select3;
    public GameObject Selected3;

    public GameObject Costume1;
    public GameObject Costume2;
    public GameObject Costume3;

    public GameObject CancelCostume;
    public static bool Wearing;

    public GameObject Checker;

    // Start is called before the first frame update
    void Start()
    {
        if (CurrentCostume == 1 || CurrentCostume == 2 || CurrentCostume == 3)
        {
            Checker.SetActive(false);
        }   
    }

    // Update is called once per frame
    void Update()
    {
        if (Selected1.activeSelf == true)
        {
            CurrentCostume = 1;
            Wearing = true;
            Checker.SetActive(false);
        }
        else if (Selected2.activeSelf == true)
        {
            CurrentCostume = 2;
            Wearing = true;
            Checker.SetActive(false);
        }
        else if (Selected3.activeSelf == true)
        {
            CurrentCostume = 3;
            Wearing = true;
            Checker.SetActive(false);
        }

        if (Checker.activeSelf == true){
            CurrentCostume = 0;
            CancelCostume.SetActive(false);
        }
        
        if (CurrentCostume == 1)
        {
            Selected1.SetActive(true);
            Selected2.SetActive(false);
            Selected3.SetActive(false);
            CancelCostume.SetActive(true);
            Wearing = true;
            Checker.SetActive(false);
        }
        else if (CurrentCostume == 2)
        {
            Selected1.SetActive(false);
            Selected2.SetActive(true);
            Selected3.SetActive(false);
            CancelCostume.SetActive(true);
            Wearing = true;
            Checker.SetActive(false);
        }
        else if (CurrentCostume == 3)
        {
            Selected1.SetActive(false);
            Selected2.SetActive(false);
            Selected3.SetActive(true);
            CancelCostume.SetActive(true);
            Wearing = true;
            Checker.SetActive(false);
        }

        if (Costume1.activeSelf == true && Selected1.activeSelf == false){
            Select1.SetActive(true);
            Select2.SetActive(false);
            Select3.SetActive(false);
        }
        else if (Costume2.activeSelf == true && Selected2.activeSelf == false){
            Select1.SetActive(false);
            Select2.SetActive(true);
            Select3.SetActive(false);
        }
        else if (Costume3.activeSelf == true && Selected3.activeSelf == false){
            Select1.SetActive(false);
            Select2.SetActive(false);
            Select3.SetActive(true);
        }

        // pag pinindot cancel costume lahat selected will be false and current costume will be 0
        

    }
}
