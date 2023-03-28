using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateTypeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Value typee variable
        Vector3 pos = transform.position;
        pos = new Vector3(0, 5, 0);

        //Reference type variable
        Transform tran = transform;
        tran.position = new Vector3(0, 2, 0);
    }
}

  