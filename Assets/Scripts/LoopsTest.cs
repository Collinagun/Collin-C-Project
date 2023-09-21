using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Before entering for loop");
        for (int i = 1; i <= 5; i++)
        {
            Debug.Log("Sam");
        }
        Debug.Log("After exiting for loop");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
