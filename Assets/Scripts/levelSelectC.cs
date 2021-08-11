using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class levelSelectC : MonoBehaviour
{
  public void playSelect() {
        SceneManager.LoadScene("playerSelect");
    }

    public void playMoveC(){
        SceneManager.LoadScene("CubeMove");
    }

     public void playJumpC(){
        SceneManager.LoadScene("CubeJump");
    }
}
