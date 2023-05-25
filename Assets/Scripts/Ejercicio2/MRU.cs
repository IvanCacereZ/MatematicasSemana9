using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MRU : MonoBehaviour
{
    public Vector3 InicialPosicion;
    public float speed = 5f;
    public Vector3 direction = new Vector3(1, 0, 0);

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        movimientoMRU();
    }
    private void movimientoMRU()
    {
        Vector3 displacement = InicialPosicion + (direction * speed * Time.deltaTime);
        rb.MovePosition(transform.position + displacement);
    }
}
