using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere_group : MonoBehaviour
{
    GameObject[] spheres;
    GameObject closest = null, furthest = null;

    // Start is called before the first frame update
    void Start()
    {
        spheres = GameObject.FindGameObjectsWithTag("spheres2");
        float closest_distance = Mathf.Infinity, furthest_distance = 0;
        foreach (GameObject sphere in spheres)
        {
            if (sphere.transform.position.sqrMagnitude < closest_distance)
            {
                closest_distance = sphere.transform.position.sqrMagnitude;
                closest = sphere;
            }
            if (sphere.transform.position.sqrMagnitude > furthest_distance)
            {
                furthest_distance = sphere.transform.position.sqrMagnitude;
                furthest = sphere;
            }
        }
        closest.transform.position = new Vector3(closest.transform.position.x, closest.transform.position.y + 5, closest.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            furthest.GetComponent<Renderer>().material.color = Color.HSVToRGB(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
    }
}
