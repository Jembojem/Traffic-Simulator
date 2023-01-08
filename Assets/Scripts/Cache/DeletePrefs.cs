using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeletePrefs : MonoBehaviour
{
    public void onLevelSelectionClick(){
        SceneManager.LoadScene("Level Selection");
    }
    public void onNextLevelClick(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    public void onResetClick(){
        PlayerPrefs.DeleteAll();
    }
}
