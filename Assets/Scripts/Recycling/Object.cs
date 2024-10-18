using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Object : MonoBehaviour
{
    public Camera myCam;

    private float startXPos;
    private float startYPos;

    private bool isDragging = false;

    private float _posX;
    private float _posY;


    private void Awake()
    {
        _posX = transform.position.x;
        _posY = transform.position.y;
    }

    private void Update()
    {
        if (isDragging)
        {
            DragObject();
        }
        else
        {
            transform.position = new Vector3(_posX, _posY, 0);
        }
    }

    private void OnMouseDown()
    {
        Vector3 mousePos = Input.mousePosition;

        if (!myCam.orthographic)
        {
            mousePos.z = 10;
        }

        mousePos = myCam.ScreenToWorldPoint(mousePos);

        startXPos = mousePos.x - transform.localPosition.x;
        startYPos = mousePos.y - transform.localPosition.y;

        isDragging = true;
    }

    private void OnMouseUp()
    {
        isDragging = false;
    }

    public void DragObject()
    {
        Vector3 mousePos = Input.mousePosition;

        if (!myCam.orthographic)
        {
            mousePos.z = 10;
        }

        mousePos = myCam.ScreenToWorldPoint(mousePos);
        transform.localPosition = new Vector3(mousePos.x - startXPos, mousePos.y - startYPos, transform.localPosition.z);
    }
}

