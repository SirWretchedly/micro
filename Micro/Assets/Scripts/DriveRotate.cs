using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveRotate : MonoBehaviour
{
    public GameObject car;
    public GameObject planet;
    public short direction;
    public float speed;
    public bool locked;

    private bool mouseDown;

    private void Start()
    {
        locked = true;
    }

    private void OnMouseDown()
    {
        mouseDown = true;
    }

    private void OnMouseUp()
    {
        mouseDown = false;
    }

    void Update()
    {
        if(mouseDown == true && locked == false)
        {
            car.transform.RotateAround(planet.transform.position, new Vector3(0, 0, direction), speed * Time.deltaTime);
        }
    }
}
