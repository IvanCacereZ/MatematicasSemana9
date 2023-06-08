using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MRU : MonoBehaviour
{
    public Vector3 InicialPosicion;
    private float speed = 0f;
    private Vector3 direction = new Vector3(1, 0, 0); //para que solo se mueva a la derecha
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void movimientoMRU()
    {
        Vector3 displacement = InicialPosicion + (direction * speed * Time.deltaTime); //lugar incial + (velocidad * tiempo * direccion)
        rb.MovePosition(transform.position + displacement);
    }
    public void SetSpeed(string text)
    {
        float Speed1;
        if (float.TryParse(text,out _))
        {
            Speed1 = float.Parse(text);
            speed = Speed1;
        }
        else
        {
            Debug.Log("no se puede");
        }
    }
    public void SetInicialPosition()
    {
        transform.position = new Vector3(-7,1,0);
    }
}