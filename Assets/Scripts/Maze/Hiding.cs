using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Hiding : MonoBehaviour
{
    public GameObject hideText, stopHideText;
    public GameObject normalPlayer; //hidingPlayer;
    //public AI_Monster monsterScript;
    public Transform monsterTransform;
    bool interactable, hiding;
    public float loseDistance;

    public Transform inLocker;
    public Transform outLocker;
    void Start()
    {
        interactable = false;
        hiding = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            hideText.SetActive(true);
            interactable = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            hideText.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    {
        if(interactable == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                hideText.SetActive(false);
                normalPlayer.transform.position = inLocker.transform.position;
                //hidingPlayer.SetActive(true);
               // float distance = Vector3.Distance(monsterTransform.position, normalPlayer.transform.position);
               // if(distance > loseDistance)
               // {
                //    if(monsterScript.chase == true ) 
               //     {
                //        monsterScript.chase = false;
                //    }
               // }
                stopHideText.SetActive(true);
                hiding = true;
                normalPlayer.SetActive(false);
                interactable = false;
            }
        }
        if(hiding == true)
        {
            if(Input.GetKeyDown(KeyCode.Q))
            {
                stopHideText.SetActive(false);
                normalPlayer.SetActive(true);
                normalPlayer.transform.position = outLocker.transform.position;
                // hidingPlayer.SetActive(false);
                hiding = false;
            }
        }
    }
}
