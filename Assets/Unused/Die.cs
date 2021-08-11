using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
    // Start is called before the first frame update
    //Death Zone!

    public Text loser;
    void Start()
    {
        loser.text="";
    
    }

     // Update is called once per frame
    void Update()
    {
        
    }



   void OnTriggerEnter2D(Collider2D otherObject)
    {
        if (otherObject.name=="Pit"){
            loser.text="You Died!";
        }
        // , collision, if(collision.tag == "Sphere"||"Cube"){Destroy(collision.gameObject);}
    }
}
//Uh. Will this work?
//It doesn't.
//Work on a reload then?