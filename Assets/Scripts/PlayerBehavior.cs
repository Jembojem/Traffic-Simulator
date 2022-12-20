using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public Rigidbody rbPlayer;
    public GameObject trafficPanel;
    bool isTrigger = false;
    void doSomething()
    {
        Debug.Log("Ini berhasil");
        // Reduce velocity
        rbPlayer.velocity = new Vector3(0, 0, 0);
        // Stop object
        rbPlayer.isKinematic = true;
        // Showing UI
        trafficPanel.SetActive(true);
    }
    public void rightAnswer(){
        trafficPanel.SetActive(false);
        rbPlayer.isKinematic = false;
    }
    public void wrongAnswer(){
        Debug.Log("Goblok anying!!");
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "Traffic Light" && !isTrigger){
            doSomething();
            isTrigger = true;
        }
    }
}
