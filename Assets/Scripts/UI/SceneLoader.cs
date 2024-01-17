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

    public void Loading()
    {
        SceneManager.LoadScene(0);
    }

}
