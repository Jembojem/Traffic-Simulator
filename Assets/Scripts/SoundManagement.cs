using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManagement : MonoBehaviour
{
    public AudioSource buttonClicked1;
    public void playSoundButtonClicked1(){
        buttonClicked1.Play();
    }
}
