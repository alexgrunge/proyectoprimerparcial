using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto_primer_parcial
{
    class opc5
    {
        static void descuento_producto(int precio, decimal descuento) // funcion con la logica del modulo
        {
            decimal valdescuento = precio * descuento;
            decimal total = precio - valdescuento;
            Console.WriteLine("el precio es de: " + precio + "\nel descuento es de: " + descuento + "\nel total es de: " + total);
            Console.ReadKey();
            Console.Clear();


        }
        public void articulos_chinos() //funcion pricipal
        {
            Console.WriteLine("selecciona un lote: \n1.10 piezas $100 \n2.50 piezas $500 \n3.caja con 100 piezas $1000 ");
            int opc = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opc)
            {
                case 1:
                    Console.WriteLine("10 piezas");
                    descuento_producto(100, 0.30m); // se llama al metodo y se le dan los argumentos 
                    break;
                case 2:
                    Console.WriteLine("50 piezas");
                    descuento_producto(500, 0.50m);
                    break;
                case 3:
                    Console.WriteLine("caja 100 piezas");
                    descuento_producto(1000, 0.70m);
                    break;
                default:
                    Console.WriteLine("el valor es erroneo ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

        }
    }
}
