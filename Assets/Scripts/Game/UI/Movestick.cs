using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Movestick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    private Vector2 pointA;
    private Vector2 pointB;
    
    public Vector2 direction;

    public bool state;

    private float radius;

    [SerializeField] private Transform joystick;
    [SerializeField] private Transform joystickBack;
    [SerializeField] private Transform sprint;
    
    private void Start()
    {
        radius = joystickBack.GetComponent<RectTransform>().rect.width / 2;
        joystick.GetComponent<Image>().enabled = false;
        joystickBack.GetComponent<Image>().enabled = false;
        sprint.GetComponent<Image>().enabled = false;
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        pointA = new Vector2(eventData.position.x, eventData.position.y);

        joystickBack.transform.position = pointA;
        joystick.transform.position = pointA;
        sprint.transform.position = new Vector2(pointA.x , pointA.y + radius);
        joystick.GetComponent<Image>().enabled = true;
        joystickBack.GetComponent<Image>().enabled = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        state = true;
        
        sprint.GetComponent<Image>().enabled = true;
        
        pointB = new Vector2(eventData.position.x, eventData.position.y);
        
        Vector2 offset = pointB - pointA;
        direction = Vector2.ClampMagnitude(offset, radius);
        joystick.transform.position = new Vector2(pointA.x + direction.x, pointA.y + direction.y);
        sprint.transform.position = new Vector2(pointA.x + direction.normalized.x * radius, pointA.y + direction.normalized.y * radius);
    }
    
    public void OnPointerUp(PointerEventData eventData)
    {
        state = false;
            
        joystick.GetComponent<Image>().enabled = false;
        joystickBack.GetComponent<Image>().enabled = false;
        sprint.GetComponent<Image>().enabled = false;
        
        joystick.transform.position = Vector2.zero;
    }
}
