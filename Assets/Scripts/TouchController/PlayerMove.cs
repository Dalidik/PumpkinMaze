using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
   // public AudioSource breath;
    public FixedJoystick joystick;
    public float SpeedMove = 5f;
    private CharacterController controller;
    
    void Start()
    {
        controller= GetComponent<CharacterController>();
    }

    
    void Update()
    {
        Moving();
       ;
      
        
    }
    void Moving()
    {
        
        Vector3 Move = transform.right * joystick.Horizontal + transform.forward * joystick.Vertical;
        controller.Move(Move * SpeedMove * Time.deltaTime);
      // breath.Play();
    }
   
    
}