using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tzouza_2 : MonoBehaviour
{
    Vector3 mikum;
    public float tsaad = 0.1f;
    public float gvulMasach = 3;

    void Start()
    {

    }

    void Update()
    {
        mikum = transform.position;
        mikum.x += tsaad;
        transform.position = mikum;


        if ((mikum.x > gvulMasach) || (mikum.x < -gvulMasach)) { tsaad *= -1; }
    }






}

