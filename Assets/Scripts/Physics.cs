using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisicas : MonoBehaviour
{
    public float MRU(float velocity, float time)
    {
        float Xf = velocity * time;
        return Xf;
    }
    public float MRUV(float IVelocity, float aceleration, float time)
    {
        float Xf = (IVelocity * time) + (aceleration * Mathf.Pow(time, 2)) / 2;
        return Xf;
    }
}
