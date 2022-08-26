using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
 
    void Start()
    {
        var cars = new Dictionary<int, string>()
        {
            { 5, "Sedan"},
            { 3, "Coupe"},
            { 11, "Suzuki"}
        };
        
        ToLog(cars);
    }

    public void ToLog(Dictionary<int, string> cars)
    {
        Debug.Log(cars);
    }
   
}