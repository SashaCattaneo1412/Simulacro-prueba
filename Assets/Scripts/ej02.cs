//2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible. Comunicar si la suma de los mismos supera o no el monto de dinero disponible. Luego indicar cuánto dinero sobra o falta.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej02 : MonoBehaviour
{
    // Start is called before the first frame update
    public float producto1;
    public float producto2;
    public float producto3;
    public float monto;

    void Start()
    {
        float sumaProductos;
        float faltante;
        float restante;
        sumaProductos = producto1 + producto2 + producto3; 
        if (sumaProductos > monto)
        {
            Debug.Log("La suma de los productos es mayor que el monto");
            faltante = sumaProductos - monto;
            Debug.Log("Te falatarian" + faltante + "pesos");
        }
        else
        {
            Debug.Log("La suma de los productos es menor que el monto");
            restante =  monto - sumaProductos;
            Debug.Log("Te sobrarian" + restante + "pesos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
