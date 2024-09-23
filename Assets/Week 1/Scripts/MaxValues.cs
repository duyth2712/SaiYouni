using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxValues : MonoBehaviour
{
    void Start()
    {
        // Giá trị lớn nhất của int
        int maxInt = 2147483647;
        Debug.Log("Giá trị lớn nhất của int: " + maxInt);

        // Giá trị lớn nhất của float
        float maxFloat = float.MaxValue; //3.4028235E+38
        Debug.Log("Giá trị lớn nhất của float: " + maxFloat);

        // Giá trị lớn nhất của double
        double maxDouble = double.MaxValue; //1.7976931348623157E+308
        Debug.Log("Giá trị lớn nhất của double: " + maxDouble);
    }

}
