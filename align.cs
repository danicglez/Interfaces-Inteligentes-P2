using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class align : MonoBehaviour
{
    GameObject cube;
    GameObject cylinder;

    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.FindWithTag("pink_cube1");
        cylinder = GameObject.FindWithTag("blue_cylinder1");
    }

    // Update is called once per frame
    void Update()
    {
        cube.transform.position = new Vector3(gameObject.transform.position.x - 5, cube.transform.position.y, cube.transform.position.z);
        cylinder.transform.position = new Vector3(gameObject.transform.position.x + 5, cylinder.transform.position.y, cylinder.transform.position.z);
    }
}
