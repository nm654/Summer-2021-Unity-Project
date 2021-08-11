using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSphere : MonoBehaviour
{
 
    // Update is called once per frame
    void Update()
    {
        //I discovered this from an earlier Project so I'm gonna use it for the Win Screen because it looks cool???
        // X, Y, Z...
        transform.Rotate(new Vector3 (20,30,45)*Time.deltaTime);
    }
}
