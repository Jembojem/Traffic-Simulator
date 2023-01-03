using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activated_traffic_sign : MonoBehaviour
{
    public Collider signCollider;
    public GameObject deactive;
    public GameObject activated;

    void Start()
    {
        activated.SetActive(false);
    }

    void OnTriggerExit(Collider other)
    {
        signCollider.enabled = true;
        activated.SetActive(false);
        Debug.Log("Active Hilang");
        deactive.SetActive(true);
        Debug.Log("Deactive Nyala");
    }
}
