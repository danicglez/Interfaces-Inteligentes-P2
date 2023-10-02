using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_array : MonoBehaviour
{
    public int maximun = 25, minimun = 0;
    int[] array;
    // Start is called before the first frame update
    void Start()
    {
        array = new int[] {Random.Range(minimun, maximun), Random.Range(minimun, maximun), Random.Range(minimun, maximun), Random.Range(minimun, maximun), Random.Range(minimun, maximun)};
    }

    // Update is called once per frame
    void Update()
    {
        array[Random.Range(0, 4)] = Random.Range(minimun, maximun);
        string aux = "";
        foreach (int number in array)
        {
            if (number > 15)
            {
                aux += number + " ";
            }
        }
        if (string.IsNullOrEmpty(aux))
        {
            Debug.Log("Ningún número es mayor que 15");
        } else 
        {
            Debug.Log(aux);
        }
    }
}
