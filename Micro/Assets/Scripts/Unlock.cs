using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlock : MonoBehaviour
{
    public Sprite unlocked;
    public string keyName;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.name == keyName)
        {
            gameObject.GetComponent<Image>().sprite = unlocked;
            foreach(DriveRotate drive in transform.parent.gameObject.GetComponentsInChildren<DriveRotate>())
            {
                drive.locked = false;
            }
            foreach(RotatePlanet drive in transform.parent.gameObject.GetComponentsInChildren<RotatePlanet>())
            {
                drive.locked = false;
            }
        }
    }
}
