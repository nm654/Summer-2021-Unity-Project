 using System.Collections;
 using System.Collections.Generic;
using UnityEngine;

 public class JumpDump : MonoBehaviour
 {
     // Start is called before the first frame update
  
     public Vector2 jump;
     public float jumpForce=2.0f;
     public bool isGrounded;
     Rigidbody2D rigidbody;
     void Start(){
         rigidbody=GetComponent<Rigidbody2D>();
         jump=new Vector2 (2.0f, 2.0f);
         isGrounded=true;

    }

   


     // Update is called once per frame
     void Update()
     {
                 //Seperate the Jump from the Rest?
         if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)  
        {
            //Go Jump!
             rigidbody.AddForce(jump*jumpForce, ForceMode2D.Impulse);
             isGrounded=false;
         }
     }
 }
 //7/30/2021: And I'm launching AGAIN....
        
// //I think the velocity is the problem here?!
//     }
// }
