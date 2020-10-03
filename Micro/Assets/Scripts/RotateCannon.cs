using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCannon : MonoBehaviour
{
    public Vector2 enemyPos;

    private float angle;

    void Update()
    {
        transform.LookAt(enemyPos);
    }
}
