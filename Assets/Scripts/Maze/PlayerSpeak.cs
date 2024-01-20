using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerSpeak : MonoBehaviour
{
    public GameObject SpeakText;
    public GameObject trigger;
    public AudioSource source;

    void Start()
    {
        SpeakText.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            source.Play();
            SpeakText.SetActive(true);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            
            Destroy(trigger, 5f);
        }
    }
}
