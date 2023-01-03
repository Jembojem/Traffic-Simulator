using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish_game : MonoBehaviour
{
    public GameObject point;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Kamu berhasil menyelesaikan Permainan");
        point.SetActive(false);

        Application.Quit();
    }
}
