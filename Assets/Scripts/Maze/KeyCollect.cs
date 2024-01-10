using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class KeyCollect : MonoBehaviour
{
    public int keys;
    public TextMeshProUGUI keyNumber;
    public TextMeshProUGUI keyText;
    public GameObject findOutText;

    public AudioClip EndSound;
    public AudioClip StartSound;
    AudioSource _source;

    private void Start()
    {
        _source = GetComponent<AudioSource>();
        
        findOutText.SetActive(false);
        
        _source.clip = StartSound;
        _source.Play();
    }
    private void Update()
    {
        keyNumber.text = keys.ToString();
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Key")
        {
          
            keys = keys + 1;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Finish" &&  keys == 3)
        {
            Time.timeScale = 0;
            SceneManager.LoadScene("End");
            Destroy(findOutText);
        }
        if(keys == 3)
        {
            Destroy(keyText);
            Destroy(keyNumber);
            findOutText.SetActive(true);
            _source.clip = EndSound;
            _source.Play();
        }
    }
    
    
}
