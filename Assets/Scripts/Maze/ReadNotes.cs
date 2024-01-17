using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class ReadNotes : MonoBehaviour
{
    public GameObject player;
    public GameObject noteUI;
    public GameObject hud;
    public GameObject inv;
    public ButtonPress butPress;
    public GameObject pickUpText;
    public Button backBut;

    public bool inReach;



    void Start()
    {
        noteUI.SetActive(false);
        hud.SetActive(true);
        inv.SetActive(true);
        pickUpText.SetActive(false);
        inReach = false;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            inReach = true;
            pickUpText.SetActive(true);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            inReach = false;
            pickUpText.SetActive(false);
        }
    }




    void Update()
    {
        if (butPress.buttonPressed == true && inReach)
        {
          
            noteUI.SetActive(true);
           
            hud.SetActive(false);
            inv.SetActive(false);
          
            pickUpText.SetActive(false);
        }

    }


    public void ExitButton()
    {
        if(inReach == true)
        {
            noteUI.SetActive(false);
            hud.SetActive(true);
            inv.SetActive(true);
           
        }

    }
}
