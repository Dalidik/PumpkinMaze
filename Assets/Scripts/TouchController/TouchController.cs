using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchController : MonoBehaviour
{
    public FixedTouchField _FixedTouchField;
    public CameraLook _CameraLook;

    public Action OnActionTrigger;
    public Button ActionBut;
    
    void Start()
    {
        ActionBut.onClick.AddListener(OnActionButtonCallBack); 
    }

     void OnActionButtonCallBack()
    {
        OnActionTrigger?.Invoke();
       
    }

    void Update()
    {
        _CameraLook.LockAxis = _FixedTouchField.TouchDist;
    }
}
