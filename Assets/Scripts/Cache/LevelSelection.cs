using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    public Button[] lvlButtons;
    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 2);
        for (int i = 0; i < lvlButtons.Length; i++){
            if(i + 2 > levelAt){
                lvlButtons[i].interactable = false;
            }
        }
    }
    public void onHomeClicked(){
        SceneManager.LoadScene("Home");
    }
    public void onOptionClicked(){
        SceneManager.LoadScene("Option");
    }
    public void onLevel1Clicked(){
        SceneManager.LoadScene("Level1");
    }
    public void onLevel2Clicked(){
        SceneManager.LoadScene("Level2");
    }
    public void onLevel3Clicked(){
        SceneManager.LoadScene("Level3");
    }
}
