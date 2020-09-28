using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseAndLock : MonoBehaviour
{
    private void OnMouseDown()
    {
        foreach (DriveRotate drive in transform.parent.gameObject.GetComponentsInChildren<DriveRotate>())
        {
            drive.locked = true;
        }
        transform.parent.Find("Lock").transform.rotation = new Quaternion(0, 0, 0, 0);
        StartCoroutine(waitAndQuit());
    }

    IEnumerator waitAndQuit()
    {
        yield return new WaitForSeconds(0.1f);
        transform.parent.gameObject.SetActive(false);
    }
}
