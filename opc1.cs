using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto_primer_parcial
{
    class opc1
    {
        public void valor_agregado() //funcion valor agregado
        {
            Console.WriteLine("escribe el precio del producto para calcular su iva...");
            float precio_producto = float.Parse(Console.ReadLine());
            float impuesto = (precio_producto * 0.16f);
            float iva = (impuesto + precio_producto);
            Console.WriteLine("\nEl precio del producto es de: " + precio_producto + "\nEl impuesto es del: " + impuesto + "\nEl total es de: " + iva);
            Console.ReadKey();
            Console.Clear();

        }
    }
}
