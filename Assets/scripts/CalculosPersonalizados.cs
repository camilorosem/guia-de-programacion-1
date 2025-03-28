using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CalculosPersonalizados : MonoBehaviour
{
    public float number1;
    public float number2;
    float resultado; 

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El resutlado de la suma entre " + number1 + " y " + number2 " es " + resultado);
        resultado = number1 + number2;
        Debug.Log("El resutlado de la resta entre " + number1 + " y " + number2 " es " + resultado);
        resultado = number1 - number2; 
        Debug.Log("El resutlado de la multiplicacion entre " + number1 + " y " + number2 " es " + resultado);
        resultado = number1 * number2;
        Debug.Log("El resutlado de la division entre " + number1 + " y " + number2 " es " + resultado);
        resultado = number1 / number2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
