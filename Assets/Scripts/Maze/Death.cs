using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor.SearchService;

public class Death : MonoBehaviour
{
   
    public GameObject Timeline;
    public GameObject hud;
    public GameObject inv;
    public AudioSource PoliceSound;
  

    private void Start()
    {
        Timeline.SetActive(false);
       PoliceSound.Play();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            PoliceSound.Stop();
            Timeline.SetActive(true);
            hud.SetActive(false);
            inv.SetActive(false);
           
           
        }
    }
  
}

