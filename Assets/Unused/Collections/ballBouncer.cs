using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballBouncer : MonoBehaviour
{
    public Rigidbody2D rb;
    public float ballForce;
    bool gameStart=false;
    //I'm on Step 7/15
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space)&& gameStart==false){
            transform.SetParent(null);
            rb.isKinematic=false;
        rb.AddForce(new Vector2 (ballForce, ballForce));
        gameStart=true;
        }
        
    }
}
