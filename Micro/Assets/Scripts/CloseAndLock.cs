using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class CloseAndLock : MonoBehaviour
{
    public Sprite locked;
    public Sprite buttonUp, buttonDown;

    private void OnMouseDown()
    {
        foreach (DriveRotate drive in transform.parent.gameObject.GetComponentsInChildren<DriveRotate>())
        {
            drive.locked = true;
        }
        transform.parent.Find("Lock").GetComponent<Image>().sprite = locked;
        transform.GetComponent<Image>().sprite = buttonDown;
        StartCoroutine(waitAndQuit());
    }

    IEnumerator waitAndQuit()
    {
        yield return new WaitForSeconds(0.1f);
        transform.GetComponent<Image>().sprite = buttonUp;
        transform.parent.gameObject.SetActive(false);
    }
}
