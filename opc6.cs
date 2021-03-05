using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto_primer_parcial
{
    class opc6
    {
        static void descuentos(int membrecia, int preciomembrecia, decimal descuento) // funcion de la logica del modulo
        {
            if (membrecia == 1)
            {
                decimal subtotal = preciomembrecia * descuento;
                decimal total =  preciomembrecia - subtotal;
                Console.WriteLine("el total de tu membrecia será de: " + total + "\nde Regalo Te llevas unas mancuernillas");
                Console.ReadKey();
                Console.Clear();

            }
            else
            {
                decimal subtotal = preciomembrecia * descuento;
                decimal total = preciomembrecia - subtotal;
                Console.WriteLine("el precio total de tu membrecia es de " + total);
                Console.ReadKey();
                Console.Clear();

            }
                
        }
        public void membresia_gim() // funcion principal
        {
            Console.WriteLine("Selecciona tu tipo de membresia \n1.membresia de un año $1800 + 30% de descuento \n2.membresia 6 meses $1000 + 10% de descuento");
            Console.WriteLine("3.membresia trimestral $800 + 5% de descuento");
            int opcmembrecia = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcmembrecia)
            {
                case 1:
                    Console.WriteLine("membrecia de un año $1800 + 30% de descuento");
                    descuentos(1, 1800, 0.30m); // se llama a la funcion dando los argumentos necesarios
                    break;
                case 2:
                    Console.WriteLine("membrecia de 6 meses $1000 + 10% de descuento");
                    descuentos(2, 1000, 0.10m);
                    break;
                case 3:
                    Console.WriteLine("membrecia trimestral $800 + 5% de descuento");
                    descuentos(3, 800, 0.05m);
                    break;
                default:
                    Console.WriteLine("No es una opcion valida");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
    }
}
