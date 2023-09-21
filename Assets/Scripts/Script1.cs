using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{

    // Variable values
    int age = 20;
    float speed = 2.5f;
    
    // Camel case
    // yes
    int NumberOfStudents = 0;
    // no
    int s = 100;

    char character = 'a';
    char cha = 'd';
    string name = "Sam";
    string welcomeMessage = "Welcome! ";

    private void OnEnable()
    {
        Debug.Log("Inside OnEnable");
    }
    private void OnDisable()
    {
        Debug.Log("Inside OnDisable");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(welcomeMessage + name);
    }

    // Update is called once per frame (loop)
    void Update()
    {
        
    }
}
