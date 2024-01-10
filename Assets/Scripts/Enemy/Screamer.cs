using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.iOS;
using UnityEngine;


public class Screamer : MonoBehaviour
{
    public AudioClip[] sounds;
    AudioSource source;
   
    

    
    void Start()
    {
        source = GetComponent<AudioSource>();
       
       
        InvokeRepeating("PlayClipAndChange", 15.0f, 30.0f);
        
    }

    void PlayClipAndChange()
    {
        source.clip = sounds[Random.Range(0, sounds.Length)];
        source.Play();
    }



}
