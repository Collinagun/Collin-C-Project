using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTesting : MonoBehaviour
{

    public GameObject[] objects;
    public Color[] colors;

    // Start is called before the first frame update
    void Start()
    {
        //Destroy(objects[2]);
        objects[0].GetComponent<Renderer>().material.color = colors[0];
        objects[1].GetComponent<Renderer>().material.color = colors[1];
        objects[2].GetComponent<Renderer>().material.color = colors[2];
        objects[3].GetComponent<Renderer>().material.color = colors[3];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
