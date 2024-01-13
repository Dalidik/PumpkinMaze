using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    KeyCollect keyCollect;
    public GameObject death;

   
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
         
            Time.timeScale = 0;
            death.SetActive(true);
           
        }
    }
}
