using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorWithKey : MonoBehaviour
{
    public Animator doorOB;
    public GameObject keyOBNeeded;
    public GameObject openText;
    public GameObject keyMissingText;
    public AudioSource openSound;
    public GameObject TridderScript;
    public bool inReach;
    public bool isOpen;

    public ButtonPress butPress;

    void Start()
    {
        doorOB.SetBool("Close", true);
        inReach = false;
        openText.SetActive(false);
        keyMissingText.SetActive(false);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            inReach = true;
            openText.SetActive(true);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            inReach = false;
            openText.SetActive(false);
            keyMissingText.SetActive(false);
        }
    }


    void Update()
    {
        if (keyOBNeeded.activeInHierarchy == true && inReach && butPress.buttonPressed == true)
        {
            keyOBNeeded.SetActive(false);
            openSound.Play();
            doorOB.SetBool("Close", false);
            doorOB.SetBool("Open", true);
            openText.SetActive(false);
            keyMissingText.SetActive(false);
            isOpen = true;
        }

        else if (keyOBNeeded.activeInHierarchy == false && inReach && butPress.buttonPressed == true)
        {
            openText.SetActive(false);
            keyMissingText.SetActive(true);
        }

        if (isOpen)
        {
            TridderScript.GetComponent<BoxCollider>().enabled = false;
            TridderScript.GetComponent<OpenDoorWithKey>().enabled = false;
        }
    }
}
