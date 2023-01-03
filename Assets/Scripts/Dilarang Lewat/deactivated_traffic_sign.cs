using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deactivated_traffic_sign : MonoBehaviour
{
    public Collider signCollider;
    public GameObject deactive;
    public GameObject activated;

    void Start()
    {
        deactive.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        signCollider.enabled = false;
        activated.SetActive(true);
        Debug.Log("Active Nyala");
        deactive.SetActive(false);
        Debug.Log("Deactive Hilang");
    }
}
