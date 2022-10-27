using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    int myInt = 5;


    void Start()
    {
        myInt = Multiplybytwo(myInt);
        Debug.Log(myInt);
    }

    int Multiplybytwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
