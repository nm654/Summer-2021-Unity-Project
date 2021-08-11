using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelButtons : MonoBehaviour
{
    // For returning to the level select screen!
    // Start is called before the first frame update
  public void playCube(){
 SceneManager.LoadScene("LevelCube");
    }

    public void playSphere(){
        SceneManager.LoadScene("LevelSelect");
    }
}
