using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPannel : MonoBehaviour
{
    private GameObject pannel;

    private void Start()
    {
        pannel = transform.parent.gameObject.transform.Find("Pannel").gameObject;
    }

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
