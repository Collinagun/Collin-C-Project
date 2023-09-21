using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{

    public float speed;
    int Result;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(addition(10, 100));
    }

    // Update is called once per frame
    void Update()
    {
        // Cause the cube to move
        transform.Translate(speed, 0, 0);
    }

    // Adds numbers together
    int addition(int a, int b)
    {
        Result = a + b;
        return Result;
    }
}
