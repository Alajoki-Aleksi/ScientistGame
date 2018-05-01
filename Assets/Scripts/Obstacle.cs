using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    public float thrust;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.AddForce(transform.right * thrust);
        rb.AddForce(transform.eulerAngles=Vector3.forward);
        rb.MoveRotation(rb.rotation + 2 * Time.fixedDeltaTime);
    }
}
