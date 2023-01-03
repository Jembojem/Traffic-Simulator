using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{


    public Transform transPlayer;

    void LateUpdate()
    {
        // Follow player position
        Vector3 newPosition = transPlayer.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;

        // Follow player rotation
        transform.rotation = Quaternion.Euler(90f, transPlayer.eulerAngles.y, 0f);

    }
}
