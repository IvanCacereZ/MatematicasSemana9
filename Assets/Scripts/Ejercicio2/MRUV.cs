using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MRUV : MonoBehaviour
{
    public Vector3 InicialPosicion;
    private float speed = 0f;
    private float acceleration = 0f;
    private Vector3 direction = new Vector3(1, 0, 0); //solo a la derecha

    private Rigidbody rb;
    private float currentSpeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentSpeed = speed;
    }
    public void movementMRUV()
    {
        currentSpeed += acceleration * Time.deltaTime; //suscribimos la aceleracion para que se multiplique por si mismo cada segundo del delta time y se sume a la velocidad
        Vector3 displacement = direction * currentSpeed * Time.deltaTime; //current speed demuestra la aceleracion, 
        rb.MovePosition(transform.position + displacement);
    }
    public void SetSpeed(string text)
    {
        float Speed1;
        if (float.TryParse(text, out _))
        {
            Speed1 = float.Parse(text);
            speed = Speed1;
        }
        else
        {
            Debug.Log("no se puede");
        }
    }
    public void SetAceleration(string text)
    {
        float Aceleration1;
        if (float.TryParse(text, out _))
        {
            Aceleration1 = float.Parse(text);
            acceleration = Aceleration1;
        }
        else
        {
            Debug.Log("no se puede");
        }
    }
    public void SetInicialPosition()
    {
        transform.position = new Vector3(-7,-3,0);
    }
}
