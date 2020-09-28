using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    public GameObject planet;
    public float speed;

    private Rigidbody2D body;
    private float distance;

    private void Start()
    {
        body = transform.GetComponent<Rigidbody2D>();
        distance = Vector2.Distance(transform.position, planet.transform.position);
    }

    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") != 0)
        {
            body.AddForce(new Vector2(Input.GetAxisRaw("Horizontal") * speed, 0));
        }
    }
}
