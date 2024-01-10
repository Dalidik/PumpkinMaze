using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{
    AudioSource source;
    [SerializeField] float delay = 5.0f;



    void Start()
    {
        source = GetComponent<AudioSource>();
        source.PlayDelayed(delay);

        
    }
    
}
