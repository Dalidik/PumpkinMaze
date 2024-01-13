using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Hide : MonoBehaviour// IPointerDownHandler, IPointerUpHandler
{
    private CharacterController controller;
   
    public Transform Target;
   // public bool buttonPressed = false;

    /* void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }
     void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }*/
    private void OnTriggerEnter(Collider other)
    {
        
            controller = other.GetComponent<CharacterController>();
            controller.enabled = false;
            controller.gameObject.transform.position = Target.position;
            controller.enabled = true;
        
       
    }
}
