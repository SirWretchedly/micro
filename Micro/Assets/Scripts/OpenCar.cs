using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCar : MonoBehaviour
{
    public GameObject pannel;

    private void OnMouseDown()
    {
        if(pannel.activeSelf == false)
        {
            pannel.SetActive(true);
        }
    }
}
