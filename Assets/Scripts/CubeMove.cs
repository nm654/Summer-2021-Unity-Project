using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CubeMove : MonoBehaviour
{
    public Vector2 speed=new Vector2(50,50);
    public Vector2 v= Vector2.zero;

  
    public Rigidbody2D rigidbody;


    void Update()
    {
        //Remember the Jump button!
        // Cube shalll... move slower? I got nothing.
        // Yeah I guess Cube and Sphere are the same lmao...
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

//The Reset
     if (Input.GetKeyDown("r")) { 
                      Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
     }

      if (Input.GetKeyDown("l")) { 
                      SceneManager.LoadScene("LevelCube");
     }

    }
}
