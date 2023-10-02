using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distances : MonoBehaviour
{
    GameObject cube;
    GameObject cylinder;

    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.FindWithTag("pink_cube1");
        cylinder = GameObject.FindWithTag("blue_cylinder1");

        Debug.Log("Distancia entre la esfera y el cubo: " + (cube.transform.position - gameObject.transform.position));
        Debug.Log("Distancia entre la esfera y el cilindro: " + (cylinder.transform.position - gameObject.transform.position));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
