using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rbPlayer;
    public float player_Thrust = 2f;
    public float player_Thrust_Forward = 0.1f;
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        // Move Forward
        rbPlayer.AddForce(0, 0, player_Thrust_Forward, ForceMode.VelocityChange);
        // Player Control
        if(Input.GetKey("a")){
            rbPlayer.AddForce(-player_Thrust, 0, 0, ForceMode.VelocityChange);
        } 
       if(Input.GetKey("d")){
            rbPlayer.AddForce(player_Thrust, 0, 0, ForceMode.VelocityChange);
        } 
    }
}
