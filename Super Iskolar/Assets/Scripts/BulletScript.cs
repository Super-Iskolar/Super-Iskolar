using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    private bool isIskolarFacingleft = InterpretInputControllerScript.isIskolarFacingleft;
    // Start is called before the first frame update
    void Start()
    {
        if(isIskolarFacingleft){
            rb.velocity = -transform.right * speed;
            rb.transform.localRotation = Quaternion.Euler(0, 180, 0);
        } else{
            rb.velocity = transform.right * speed;
        }
    }
    
}
