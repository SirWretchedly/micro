using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseAndLock : MonoBehaviour
{
    public Sprite locked;

    private void OnMouseDown()
    {
        foreach (DriveRotate drive in transform.parent.gameObject.GetComponentsInChildren<DriveRotate>())
        {
            drive.locked = true;
        }
        transform.parent.Find("Lock").GetComponent<Image>().sprite = locked;
        StartCoroutine(waitAndQuit());
    }

    IEnumerator waitAndQuit()
    {
        yield return new WaitForSeconds(0.1f);
        transform.parent.gameObject.SetActive(false);
    }
}
