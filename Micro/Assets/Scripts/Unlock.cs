using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock : MonoBehaviour
{
    public string keyName;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.name == keyName)
        {
            foreach(DriveRotate drive in transform.parent.gameObject.GetComponentsInChildren<DriveRotate>())
            {
                drive.locked = false;
            }  
        }
    }
}
