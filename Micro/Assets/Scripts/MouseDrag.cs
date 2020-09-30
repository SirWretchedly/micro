using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    public int layer;

    private bool isDragging;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void OnMouseDown()
    {
        isDragging = true;
        transform.GetComponent<SpriteRenderer>().sortingOrder = layer + 1;
        foreach(MouseDrag drag in transform.parent.GetComponentsInChildren<MouseDrag>())
        {
            drag.layer = layer + 1;
        }
    }

    public void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        if (isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
        else
        {
            Cursor.visible = true;
        }
    }
}
