using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playGame(){
        SceneManager.LoadScene("Level Selection");
    }
    public void gameOption(){
        SceneManager.LoadScene("Option");
    }
    public void quitGame(){
        Application.Quit();
        Debug.Log("Dah quit ges");
    }
}
