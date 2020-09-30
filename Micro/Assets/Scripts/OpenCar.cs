using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCar : MonoBehaviour
{
    public Sprite highlight;
    public GameObject pannel;

    private void OnMouseDown()
    {
        if(pannel.activeSelf == false)
        {
            pannel.SetActive(true);
        }
    }

    private void OnMouseEnter()
    {
        transform.GetComponent<Animator>().SetBool("highlighted", true);
    }

    private void OnMouseExit()
    {
        transform.GetComponent<Animator>().SetBool("highlighted", false);
    }
}
