using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MRUV : MonoBehaviour
{
    public Vector3 InicialPosicion;
    public float speed = 5f;
    public float acceleration = 2f;
    public Vector3 direction = new Vector3(1, 0, 0);

    private Rigidbody rb;
    private float currentSpeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentSpeed = speed;
    }

    private void FixedUpdate()
    {
        movementMRUV();
    }
    private void movementMRUV()
    {
        currentSpeed += acceleration * Time.deltaTime;
        Vector3 displacement = direction * currentSpeed * Time.deltaTime;
        rb.MovePosition(transform.position + displacement);
    }
}
