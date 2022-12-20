using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    
public class DeathZone : MonoBehaviour
{
    void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.tag == "Player"){
            GameObject.Find("Correct Panel").SetActive(false);
        }
    }
}
