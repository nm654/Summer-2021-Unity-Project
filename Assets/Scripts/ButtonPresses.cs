using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPresses : MonoBehaviour
{
    public void playSelect() {
        SceneManager.LoadScene("playerSelect");
    }
    //I got this one from another Game
    // Wait, I can load levels by using the loadscene! Let's goooo?
    public void playTitle() {
        SceneManager.LoadScene("TitleScreen");
    }

    public void playCube(){
 SceneManager.LoadScene("LevelCube");
    }

    public void playSphere(){
        SceneManager.LoadScene("LevelSelect");
    }
    // I'm just gonna like. Lol... change the Win Screen to be the Title Screen.

    public void playCredits(){
        SceneManager.LoadScene("WinScreen");
    }

        public void exitGame() {
        Application.Quit();
    }
}

