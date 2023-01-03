using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traffic_sign : MonoBehaviour
{
    public GameObject player;

    public Rigidbody rigPlayer;

    public Transform spawnPoint;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Tidak Boleh Lewat Sini");

        RespawnPoint();

        rigPlayer.isKinematic = false;
    }

    void RespawnPoint()
    {
        player.transform.position = spawnPoint.position;
        player.transform.rotation = spawnPoint.rotation;
        rigPlayer.isKinematic = true;
    }
}
