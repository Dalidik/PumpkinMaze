using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    [SerializeField] int timeToWait = 5;
    int currentSceneIndex;
    [SerializeField] int scene;

    private void Start()
    {
       
            StartCoroutine(WaitForTime());
        

    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(scene);
    }
}
