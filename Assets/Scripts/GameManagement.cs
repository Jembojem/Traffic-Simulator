using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{
    public GameObject playerCamera;
    public GameObject player;
    public GameObject stopZone;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 stopZonePosition = stopZone.transform.position;
        Vector3 playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // if(stopZonePosition = playerPosition){

        // }
    }

    void CameraMovement(){

    }
}
