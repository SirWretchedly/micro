using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildItem : MonoBehaviour
{
    public GameObject item;
    public GameObject spawner;

    private GameObject instance;

    private void OnMouseDown()
    {
        instance = GameObject.Instantiate(item, spawner.transform.position, spawner.transform.rotation);
        instance.transform.position = instance.transform.position + new Vector3(0, 0, 0.001f);
        instance.GetComponent<SpriteRenderer>().sortingOrder = -1;
    }
}
