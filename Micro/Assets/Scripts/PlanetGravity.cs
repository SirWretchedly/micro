using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGravity : MonoBehaviour
{
    public GameObject planet;
    public float gravityForce, gravityDistance;

    private float distance;
    private Vector3 force;
    private Rigidbody2D body;

    private void Start()
    {
        body = transform.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        distance = Vector2.Distance(planet.transform.position, transform.position);
        force = planet.transform.position - transform.position;
        body.AddForce(force.normalized * (1 - distance / gravityDistance) * gravityForce);
    }
}
