using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PickUpFlashLight : MonoBehaviour
{
    public GameObject FlashLightPlayer;
    public GameObject Text;
   
    public ButtonPress butPress;
    void Start()
    {
        FlashLightPlayer.SetActive(false);
        Text.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Text.SetActive(true);

            if (butPress.buttonPressed == true)
            {
                this.gameObject.SetActive(false);
                FlashLightPlayer.SetActive(true);
               
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Text.SetActive(false);
    }
}
