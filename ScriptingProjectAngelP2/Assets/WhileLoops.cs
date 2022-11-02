using System.Collections;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    int cupsInTheSink = 4;

    void Start()
    {
        while (cupsInTheSink > 0)
        {
            Debug.Log("Ive washed a cup!");
            cupsInTheSink--;
        }
    }
}


   
        
    

