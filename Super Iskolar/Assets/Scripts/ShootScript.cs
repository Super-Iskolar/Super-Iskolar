using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{

    public Transform firePencil;
    public GameObject pencil;

    // Update is called once per frame
    void Update()
    {
    }

    public void Shoot(){
        Instantiate(pencil, firePencil.position, firePencil.rotation);
    }
}
