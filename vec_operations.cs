using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vec_operations : MonoBehaviour
{
    public Vector3 vec1;
    public Vector3 vec2;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Operaciones con vec1 y vec2:");
        Debug.Log("Magnitudes vec1: " + vec1.sqrMagnitude + ", vec2: " + vec2.sqrMagnitude);
        Debug.Log("Angulo entre los vectores: " + Vector3.Angle(vec1, vec2));
        Debug.Log("Distancia entre los vectores: " + Vector3.Distance(vec1, vec2));
        if (vec1[1] <= vec2[1]) 
        {
            Debug.Log("Vector a más altura: " + vec2);
        }
        else 
        {
            Debug.Log("Vector a más altura: " + vec1);
        }
        Debug.Log("Fin operaciones con vec1 y vec2");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
