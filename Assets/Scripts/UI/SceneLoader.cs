using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using AsyncOperation = UnityEngine.AsyncOperation;

public class SceneLoader : MonoBehaviour
{
    public GameObject LoadingScreen;
    public Image LoadingBarFill;


     public void LoadScene(int sceneId)
     {
       StartCoroutine(LoadSceneAsync(sceneId));
     }
    
    IEnumerator LoadSceneAsync(int sceneId)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneId);
        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progressValue = Mathf.Clamp01(operation.progress / .9f); 
            LoadingBarFill.fillAmount = progressValue;
            yield return null;
        }
    }
}
