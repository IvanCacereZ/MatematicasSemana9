using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 1.0f;
    public float aceleration = 1.0f;
    private float time = 5f;
    private float currentSpeed;
    [SerializeField] private Transform target;

    void Update()
    {
        currentSpeed += aceleration * Time.deltaTime;
        var step = speed * currentSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Perdiste");
        Destroy(collision.gameObject);
        Destroy(this.gameObject);
    }
}
