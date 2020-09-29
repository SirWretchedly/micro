using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseAndReturn : MonoBehaviour
{
    public Sprite buttonUp, buttonDown;

    private GameObject parent;

    private void OnMouseDown()
    {
        foreach (ReturnObject item in transform.parent.gameObject.GetComponentsInChildren<ReturnObject>())
        {
            item.GetComponent<ReturnObject>().closed = true;
        }
        transform.GetComponent<Image>().sprite = buttonDown;
        StartCoroutine(waitQuit());
    }

    IEnumerator waitQuit()
    {
        yield return new WaitForSeconds(0.1f);
        transform.GetComponent<Image>().sprite = buttonUp;
        transform.parent.gameObject.SetActive(false);
    }
}
