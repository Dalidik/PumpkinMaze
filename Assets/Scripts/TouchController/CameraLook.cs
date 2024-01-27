using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraLook : MonoBehaviour
{
    private float XMove;
    private float YMove;
    private float XRotation;
    [SerializeField] private Transform PlayerBody;
    public Vector2 LockAxis;

    public float Sensivity = 20f;
    public Slider slider;

    private void Start()
    {
        
    }
    void Update()
    {
        
        float BaseSensivity =  slider.value * Sensivity;
        XMove = LockAxis.x * BaseSensivity * Time.deltaTime;
        YMove = LockAxis.y * BaseSensivity * Time.deltaTime;
        XRotation -= YMove;
        XRotation = Mathf.Clamp(XRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(XRotation,0,0);
        PlayerBody.Rotate(Vector3.up * XMove);
    }
    public void LoadSettings()
    {
        Sensivity = PlayerPrefs.GetFloat("Sensivity");
    }
    public void SaveSettings()
    {
        PlayerPrefs.SetFloat("Sensivity", Sensivity);
        PlayerPrefs.Save();
    }
}
