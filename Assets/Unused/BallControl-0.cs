// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class BallControl : MonoBehaviour
// {
//     public int movementSpeed=5;
//     public int bounceCount;
//     private float leftBound = -20f;
//     private float rightBound = 20f;
//     private float topBound = 10f;
//     private float bottomBound = -10f;
//     //heh.

// // Book VS Youtube, which will work? 
// // IDK Youtube seems to be pretty good so far...
//     //Thank you tutorials, very cool!
//     //bounceCount--;

//     string bounceCounter = "Bounces " + bounceCount;
//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     //. notation is to denote the function of the classes
//     void Update()
//     {
//         //move Right
//         rightBall.velocity=movementDirection*movementSpeed;
//         if (movementDirection.x==1&&myTransformation.position.x>=rightBound){
//             movementDirection.x=-1;
//             bounceCount++;
//         }

//         // left
//     if (movementDirection.x == -1 && myTransformation.position.x <= leftBound){
//         movementDirection.x = 1;
//         bounceCount++;
//         }

//         // top
//         if (movementDirection.y == 1 && myTransformation.position.y >= topBound){
//         movementDirection.y = -1;
//         bounceCount++;
// }
// // bottom
//     if (moveDirection.y == -1 && myTransformation.position.y <= bottomBound) {
//     movementDirection.y = 1;
//     bounceCount++;
//         }
// //heh!
//     }
// }
