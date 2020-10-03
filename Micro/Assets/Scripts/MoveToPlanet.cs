using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlanet : MonoBehaviour
{
    public GameObject planet;
    public float speed;
    public float rotateSpeed;

    private int rng;
    private bool done;
    private short action = 1;

    private void Start()
    {
        done = true;
    }

    void Update()
    {
        if (done == true)
        {
            StartCoroutine(choseMove());
        }
        switch (action)
        {
            case 1:
                transform.position = Vector3.MoveTowards(transform.position, planet.transform.position, speed * Time.deltaTime);
                break;
            case 2:
                transform.RotateAround(planet.transform.position, new Vector3(0, 0, -1), rotateSpeed * Time.deltaTime);
                break;
            case 3:
                transform.RotateAround(planet.transform.position, new Vector3(0, 0, 1), rotateSpeed * Time.deltaTime);
                break;
        }
    }

    IEnumerator choseMove()
    {
        done = false;
        yield return new WaitForSeconds(0.5f);
        rng = Random.Range(0, 10);
        if (rng < 5)
        {
            action = 1;
        }
        else
        {
            if (rng < 8 && transform.position.y < 4.5)
            {
                action = 2; 
            }
            else
            {
                if(transform.position.y > -4.5)
                {
                    action = 3;
                }
                else
                {
                    action = 2;
                }
            }
        }
        done = true;
    }
}