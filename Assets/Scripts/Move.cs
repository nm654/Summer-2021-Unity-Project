using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    public Vector2 speed=new Vector2(50,50);
    public Vector2 v= Vector2.zero;

  
    public Rigidbody2D rigidbody;


    void Update()
    {
        //Remember the Jump button!
        // Cube shall have... no friction! Also no Double jump!
bool movement=false;
        //Press Left or the A button?
        // Remove the A button Prompt
        if (Input.GetKey(KeyCode.LeftArrow)) 
        {  movement=true;
            //Go Left!
            v=Vector2.left*speed;
           // Debug.log(v);
        }
        
          if (Input.GetKey(KeyCode.RightArrow))
        { movement=true;
            //Go Right!
            v=Vector2.right*speed;
        }
        if (!movement){
            v.x=0;
        }
        v.y=rigidbody.velocity.y;
        rigidbody.velocity=v;

//Pause!        
        if (Input.GetKeyDown(KeyCode.P)){
            if (Time.timeScale==0){
                Time.timeScale=1;
            }
            else {
                Time.timeScale=0;
            }
        }

//Reset?
//Sphere Resets only
     if (Input.GetKeyDown("r")) { //If you press R
         //SceneManager.LoadScene("The Descent"); //Load scene... Oh, so I'd need to apply this for every single Level??? (Big Oof.)
         //I think I'd need to apply this for every single Sphere Level but renamed so I don't end up loading everything. WHAT?
         //SceneManager.LoadScene("Stairway"); 
         //Yes, I do need to make multiple move instances of code so that the reset properly works. (Yikes!
         // Isn't there a scenemanager.loadscene current or something?)
         // Yeah try this one

                      Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
     }
      if (Input.GetKeyDown("l")) { 
                      SceneManager.LoadScene("LevelSelect");
      }

    }
}
