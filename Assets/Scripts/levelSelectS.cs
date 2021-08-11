using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class levelSelectS : MonoBehaviour
{
    public void playSelect() {
        SceneManager.LoadScene("playerSelect");
    }

    public void playTitle() {
        SceneManager.LoadScene("TitleScreen");
    }
    
    public void playMove(){
    SceneManager.LoadScene("Level1");}
    public void playJump (){
    SceneManager.LoadScene("Level2");}
    public void playDescent(){
    SceneManager.LoadScene("Level3");}

    public void playSteps(){
    SceneManager.LoadScene("Level4");}

    public void playStairs(){
    SceneManager.LoadScene("Level5");}

     public void playTrio(){
    SceneManager.LoadScene("Level6");}

    public void playLeap(){
    SceneManager.LoadScene("Level7");}

    public void playMovep(){
    SceneManager.LoadScene("Level8");}
}
