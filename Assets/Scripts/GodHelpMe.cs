using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodHelpMe : MonoBehaviour
{
    public int maxJumps;
    private int jumpCounter;
public  Vector2 jumpSpeed;
     public Rigidbody2D rigidbody;

     public Vector2 jumpVelocity;

//HOW DO I ENABLE GRAVITY
// Use this for initialization
 public Vector2 jump;
     public float jumpForce=2.0f;
     public bool isGrounded;
     
     void Start(){
         //rigidbody=GetComponent<Rigidbody2D>();
         jump=new Vector2 (2.0f, 2.0f);
         //isGrounded=true;
         jumpCounter=maxJumps;
         

    }
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.transform.CompareTag("Ground")){
            isGrounded=true;
            jumpCounter=maxJumps;
        }
    }
// Update is called once per frame
void Update ()
{
    //public Vector2 jumpVelocity = new Vector2(2.0f, jumpSpeed);
       if (Input.GetKeyDown(KeyCode.UpArrow)&& (isGrounded || jumpCounter>0))  //JUMP, DANGIT
    {
    // Wait, Wasn't it something about velocity....?
    
      rigidbody.AddForce(jump*jumpVelocity, ForceMode2D.Impulse);
      rigidbody.velocity += jumpVelocity;
      if (!isGrounded){
          jumpCounter--;
      }
      isGrounded=false;

      //7/31 Update: Did You remember the Gravity Scale? To Not make it 0?
      // Tip: I am so mad. I'm gonna go to bed at almost 3 am so I can have a clear head about how mad I am.
      // Yaaay, The Jump semi Works!
}
}
}
