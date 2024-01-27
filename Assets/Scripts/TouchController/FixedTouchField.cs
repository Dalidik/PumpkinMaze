using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FixedTouchField : MonoBehaviour , IPointerDownHandler, IPointerUpHandler
{
    [HideInInspector]
    public Vector2 TouchDist;
    [HideInInspector]
    public Vector2 PointerOld;
    [HideInInspector]
    protected int PointerId;
    [HideInInspector]
    public bool Pressed;

    public Slider slider;


    public float RotationSpeed = 1f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

        if (Pressed)
        {
            if (PointerId >= 0 && PointerId < Input.touches.Length)
            {
                TouchDist = Input.touches[PointerId].position * RotationSpeed - PointerOld;
                PointerOld = Input.touches[PointerId].position * RotationSpeed ;
            }
            else
            {
                TouchDist = new Vector2(Input.mousePosition.x , Input.mousePosition.y ) - PointerOld;
                PointerOld = Input.mousePosition;
            }
        }
        else
        {
            TouchDist = new Vector2();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;
        PointerId = eventData.pointerId;
        PointerOld = eventData.position;
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }
}
