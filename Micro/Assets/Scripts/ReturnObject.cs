using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnObject : MonoBehaviour
{
    public bool closed;
    public float distance;

    private Vector3 parent;

    private void Start()
    {
        parent = transform.parent.position;
    }

    void Update()
    {
        if(closed == true && Vector3.Distance(transform.position, parent) > distance)
        {
            transform.position = parent;
        }
    }
}
