using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalObjectReturn : MonoBehaviour
{
    private GameObject parent;

    private void OnMouseDown()
    {
        foreach (ReturnObject item in transform.parent.gameObject.GetComponentsInChildren<ReturnObject>())
        {
            item.GetComponent<ReturnObject>().closed = true;
        }
        StartCoroutine(waitQuit());
    }

    IEnumerator waitQuit()
    {
        yield return new WaitForSeconds(0.1f);
        transform.parent.gameObject.SetActive(false);
    }
}
