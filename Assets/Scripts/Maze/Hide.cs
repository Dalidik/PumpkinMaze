using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Hide : MonoBehaviour
{
    public CharacterController controller;
    public GameObject In;
    public Transform Out;
    public ButtonPress butPress;
    bool intered = false;
    public AudioSource source;
    public AudioClip openLockerSound;
    public AudioClip breath;


    private void Update()
    {
        
        if (intered == true && butPress.buttonPressed == true)
        {
            source.PlayOneShot(openLockerSound);
            source.PlayOneShot(breath);
            controller.enabled = false;
            controller.gameObject.transform.position = Out.position;
            controller.enabled = true;
        }

     

    }



    private void OnTriggerEnter(Collider other)
    {
       
        intered = true;
            Debug.Log("+");
        In.SetActive(false);
    }


    private void OnTriggerExit(Collider other)
    {
        
            Debug.Log("-");
            intered = false;
        In.SetActive(true);


    }
   
}
