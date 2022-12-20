using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public Rigidbody rbPlayer;
    private bool isTrigger = false;
    // public void OnCollisionEnter(Collision col)
    // {
    //     if(!isCollision){
    //         if(col.gameObject.name == "Traffic Light Prefab"){
    //             isCollision = true;
    //         }
    //     }
    // }
    public void OnTrigger(Collider col)
    {
        if(!isTrigger){
            if(col.gameObject.name == "Traffic Light Prefab"){
                isTrigger = true;
                rbPlayer.velocity = new Vector3(0, 0, 0);
                Debug.Log("anda melewati tempek");
            }
        }
    }
}
