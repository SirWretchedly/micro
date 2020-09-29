using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DriveRotate : MonoBehaviour
{
    public Sprite buttonDown, buttonUp;
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
        transform.GetComponent<Image>().sprite = buttonDown;
    }

    private void OnMouseUp()
    {
        mouseDown = false;
        transform.GetComponent<Image>().sprite = buttonUp;
    }

    void Update()
    {
        if(mouseDown == true && locked == false)
        {
            car.transform.RotateAround(planet.transform.position, new Vector3(0, 0, direction), speed * Time.deltaTime);
        }
    }
}
