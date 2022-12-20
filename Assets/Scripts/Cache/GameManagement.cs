using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{
    public GameObject playerCamera;
    public GameObject player;
    public GameObject stopZone;
    public Vector3 stopZonePos;
    public Vector3 playerPos;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(stopZonePos == playerPos - new Vector3(0,0,-3f)){
            
        }
    }

    void CameraMovement(){

    }
}
