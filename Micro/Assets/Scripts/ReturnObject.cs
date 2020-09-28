using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnObject : MonoBehaviour
{
    public bool closed;

    private Vector3 parent;

    private void Start()
    {
        parent = transform.parent.position;
    }

    void Update()
    {
        if(closed == true && Vector3.Distance(transform.position, parent) > 1.5)
        {
            transform.position = parent;
        }
    }
}
