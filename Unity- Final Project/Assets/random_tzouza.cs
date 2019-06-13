using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_tzouza : MonoBehaviour
{
    Vector3 mikum;
    public float tsaad = 0.1f;
    public float gvulMasach = 3;
    public float sikuiShinuiKivun = 0.09f;
    public float rand;

    void Start()
    {

    }

    void Update()
    {
        mikum = transform.position;
        mikum.x += tsaad;
        transform.position = mikum;
        if ((mikum.x > gvulMasach) || (mikum.x < -gvulMasach)) { tsaad *= -1; }
        rand = Random.value;
        if (rand < sikuiShinuiKivun) { tsaad *= -1; }

    }

}

