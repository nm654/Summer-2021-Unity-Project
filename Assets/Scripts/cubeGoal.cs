using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class cubeGoal : MonoBehaviour
{
   public Text winText;
    // Start is called before the first frame update
    void Start(){

        winText.text="";
    }
    void OnTriggerEnter2D(Collider2D otherObject)
    {
        if (otherObject.name=="CubePlayer"){
            winText.text="Goal!";
            //Load Level Select Screen
            
            SceneManager.LoadScene("LevelCube");
            //8/2 Update: Remember, you need to make seperate everythings for Cube (RIP my time today)

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}