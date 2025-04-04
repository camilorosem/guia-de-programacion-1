using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulacroDePrueba : MonoBehaviour
{
    //1. Definición de variables
    public int cantidadDias;
    public string codigoAnimal;
    int gramosComidaTotal;
    int racionGatos = 300;
    int racionPerros = 400;
    int racionPerrosGrande = 700;
    int relacionAnimalActual;
    float costoAlimenticio;
    float precioPorCienGramos = 80;

    // Start is called before the first frame update
    void Start()
    {
        //2. Ingreso de datos (mas adelante )
        if (codigoAnimal == "G");
        {
            relacionAnimalActual = racionGatos;
        } else if (codigoAnimal == "PP");
        {
            relacionAnimalActual = racionPerros;
        }else if (codigoAnimal = racionPerrosGrande);
        {
            relacionAnimalActual = racionPerrosGrande;
        }

        //3. Procesamiento de datos 
        gramosComidaTotal = relacionAnimalActual + cantidadDias;
        //4. Mostrar resultado
        Debug.Log("Para ese periodo se necesitan " + gramosComidaTotal + " gramos de alimento ");
        Debug.Log("Costo alimento" + costoAlimenticio);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
