using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class CubeSelects : MonoBehaviour
{
  public void playSelect() {
        SceneManager.LoadScene("playerSelect");
    }

    public void playTitle() {
        SceneManager.LoadScene("TitleScreen");
    }
    
    public void playMove(){
    SceneManager.LoadScene("Level1C");}
    public void playJump (){
    SceneManager.LoadScene("Level2C");}
    public void playDescent(){
    SceneManager.LoadScene("Level3C");}

    public void playSteps(){
    SceneManager.LoadScene("Level4C");}

    public void playStairs(){
    SceneManager.LoadScene("Level5C");}

        public void playTrio(){
    SceneManager.LoadScene("Level6C");}

    public void playLeap(){
    SceneManager.LoadScene("Level7C");}

    public void playMovep(){
    SceneManager.LoadScene("Level8C");}
}
