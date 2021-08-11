using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    //Credits to MisterSkitz for the Fix if it works
    private bool onGround = true; // Start on the Ground


    public Vector2 jump;
    public float jumpForce=2.0f; 
    public Rigidbody2D rigidbody;
    // Start is called before the first frame update
      public bool isGrounded;
    //Rigidbody rigidbody;
    void Start(){
        rigidbody=GetComponent<Rigidbody2D>();
        jump=new Vector2 (2.0f, 2.0f);
        isGrounded=true;
        Pleasejump();

    }


 //*      if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded==True)
     //   {
            //Go Jump!
       //     rigidbody.AddForce(jump*jumpForce);
           // isGrounded=false;
            
         //   rigidbody.velocity = new Vector2(0, jump);
         //   onGround = false;
       // } *//

 
void Pleasejump()
    {
 
        if (Input.GetKeyDown(KeyCode.UpArrow) && onGround==true)
        {
 
        }
 
    }
       void OnCollisionEnter2D(Collision2D collision)
    // Might be a Fix from a Video?
    // It does NOTHING. // Try making a seperate jump script???
        {
            if (collision.gameObject.tag == "Ground") {
     
     
                isGrounded = true;
     
            }
        }

}
