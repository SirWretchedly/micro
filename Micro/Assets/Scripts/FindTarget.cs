using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTarget : MonoBehaviour
{
    private float distance, min = 99999;
    private Vector3 enemyPos;

    void Update()
    {
        foreach(GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            distance = Vector2.Distance(transform.position, enemy.transform.position);
            if(distance < min)
            {
                min = distance;
                enemyPos = enemy.transform.position;
            }
        }
        transform.GetComponent<RotateCannon>().enemyPos = Camera.main.WorldToViewportPoint(enemyPos);
    }
}
