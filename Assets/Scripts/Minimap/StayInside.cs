using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayInside : MonoBehaviour
{
    public Transform minimapCam;
    public float minimapSize;
    Vector3 TempVec3;

    // Update is called once per frame
    void Update()
    {
        TempVec3 = transform.parent.transform.position;
        TempVec3.y = transform.position.y;
        transform.position = TempVec3;
    }

    void LateUpdate()
    {
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, minimapCam.position.x - minimapSize, minimapSize + minimapCam.position.x),
            transform.position.y,
            Mathf.Clamp(transform.position.z, minimapCam.position.z - minimapSize, minimapSize + minimapCam.position.z)
        );
    }
}
