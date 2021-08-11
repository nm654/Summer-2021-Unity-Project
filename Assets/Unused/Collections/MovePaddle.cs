using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePaddle : MonoBehaviour
{
    //Make sure every game has a return to Minigames and Quit Button!
    public Rigidbody2D rb;
    public float speedy;

    public float maxX;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //no Key down?
    //didn't work. Go for Key down.
//Thank you tutorials, very cool!
    // Update is called once per frame
    void Update()
    {
        float x= Input.GetAxis("Horizontal");

        if (x<0){ moveLeft();}
         if (x>0){moveRight();}
          //if (x==0){stop();}
        //whaat the heck?
        // Math is math functions
        //Clamp is point value to compare against
        Vector3 pos=transform.position;
        //Is that allowed?
          pos.x=Mathf.Clamp(pos.x, -maxX, maxX);
          transform.position=pos;
    }

    void moveLeft(){

        if (Input.GetKey(KeyCode.LeftArrow)) {
        rb.velocity=new Vector2(-speedy,0);
        }
    }
    void moveRight(){
        if (Input.GetKey(KeyCode.RightArrow)){
        rb.velocity=new Vector2(speedy,0);
        }
    }

    //void stop(){
      //  if (Input.GetKey(KeyCode.DownArrow)){
        //rb.velocity=Vector2.zero;
       // }
    //}

    //I don't think you need the stop?


}
