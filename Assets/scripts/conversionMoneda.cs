using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conversionMoneda : MonoBehaviour
{

    public float montoAContvertir;
    public string codigoMoneda;
    float cotizacionDolar;
    float cotizacionEuro;
    float cotizacionReal;
    float montoComvertido;
    float montoMinimo = 1000;
    float cotizacionMonedaElegida;

    // Start is called before the first frame update
    void Start()
    {
        //Ingreso y validacion de Datos
        if(montoAContvertir < montoMinimo)
         {
            Debug,Log("El monto minimo es $1000")
                return;
         }
        if(codigoMoneda == "D")
         {
            montoComvertido = cotizacionDolar * montoAContvertir
         }else if (codigoMoneda == "E")
         {
            montoComvertido = cotizacionEuro * montoAContvertir
         } else if (codigoMoneda == "R")
         {
            montoComvertido = cotizacionReal * montoAContvertir
         } else
            Debug.Log("Opcion de moneda extranjera no valida")

        //procesamiento de datos

        //salida
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
