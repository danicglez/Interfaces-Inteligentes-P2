using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show_pos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Posicion de la esfera: " + gameObject.transform.position.x + " | " + gameObject.transform.position.y + " | " + gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
