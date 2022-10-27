using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    //Creating the variables for the coffees temperature 
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;

    }

    void TemperatureTest()
    {
        //If the coffee's temperature is greater than the hottest drinking temperature...
        if (coffeeTemperature > hotLimitTemperature)
        {
            //... do this 
            print("coffee is too hot.");
        }
        // If it isn't, bnut the coffee is less than the coldest drinking temperature...
        else if (coffeeTemperature < coldLimitTemperature)
        {

            // ...do this
            print("coffee is too cold.");
        }
        // If it is neither of those then...
        else
        {
            //.do this 
            print("coffeeTemperature is just right");





                    }

    }
}