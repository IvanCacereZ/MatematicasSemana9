using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float[] times;
    [SerializeField] private Transform[] targets;
    int toward;
    float speed = 4.0f;
    float distance;
    void Awake()
    {
        toward = GetRandomToward(toward);
        distance = GetDistance(transform.position, targets[toward]);
        speed = GetMRUSpeed(distance, times[toward]);
    }

    void Update()
    {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targets[toward].position, step);

        // Check if the position of the cube and sphere are approximately equal.
        if (Vector3.Distance(transform.position, targets[toward].position) < 0.001f)
        {
            toward = GetRandomToward(toward);
            distance = GetDistance(transform.position,targets[toward]);
            speed = GetMRUSpeed(distance, times[toward]);
        }
    }
    int GetRandomToward(int toward)
    {
        int Next;
        if (toward < targets.Length - 1)
        {
            toward = toward + 1;
            Next = toward;
        }
        else
        {
            toward = 0;
            Next = toward;
        }
        return Next;
    }
    float GetMRUSpeed(float distance, float time)
    {
        float Speed = distance / time;
        return Speed;
    }
    float GetDistance(Vector3 A, Transform B)
    {
        float distance;
        float Xpos = A.x - B.position.x;
        float Ypos = A.y - B.position.y;
        float Zpos = A.z - B.position.z;
        distance = Mathf.Pow(Xpos, 2) + Mathf.Pow(Ypos, 2) + Mathf.Pow(Zpos, 2);
        distance = Mathf.Sqrt(distance);
        return distance;
    }
}
