using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    public GameObject TimelineFinish;
  

    private void Start()
    {
        TimelineFinish.SetActive(false);
       
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
           

            TimelineFinish.SetActive(true);
           

        }
    }
}
