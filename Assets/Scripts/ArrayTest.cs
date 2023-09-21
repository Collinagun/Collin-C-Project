using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Notes
// syntax error (normally a character is missing such as a semi-colon[;])
// logic error (hardest to get)
// run-time error (when the values do not match up; 5-4x2 = ?, 2 is wrong & -3 is correct)
// Remember that in an index, order matters and the first value starts with 0


public class ArrayTest : MonoBehaviour
{
    
    // Interger type array
    public int[] score = new int[5];
    // An array with string type
    string str;

    string[] names = new string[4];

    //[10, 20, 30, 40, 50]
    

    // Start is called before the first frame update
    void Start()
    {
        // placeholder
        // score[0];
        names[0] = "Sam";
        names[1] = "Peter";
        names[2] = "Alicia";
        names[3] = "Nika";

        Debug.Log(names[3]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
