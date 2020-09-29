using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPannel : MonoBehaviour
{
    public GameObject pannel;

    private void OnMouseDown()
    {
        if(pannel.activeSelf == false)
        {
            foreach(ReturnObject item in pannel.GetComponentsInChildren<ReturnObject>())
            {
                item.closed = false;
            }
            pannel.SetActive(true);
        }
    }
}
