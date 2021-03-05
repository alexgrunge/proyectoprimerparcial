using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto_primer_parcial
{
    class opc3
    {
        static void calculo_envioeimpuesto(decimal subtotal, decimal envío, decimal impuesto) //funcion con la logica del modulo
        {
            decimal impuesto_envio = subtotal * envío;
            decimal total_envio = subtotal + impuesto_envio;
            decimal valor_impuesto = total_envio * impuesto;
            decimal valor_total = valor_impuesto + total_envio;
            Console.WriteLine("el subtotal es de: " + subtotal);
            Console.WriteLine("el impuesto del envío es de: " + envío);
            Console.WriteLine("el valor total con envío es de: " + total_envio);
            Console.WriteLine("el impuesto es de: " + impuesto);
            Console.WriteLine("el valor total es de: " + valor_total);
            Console.ReadKey();
            Console.Clear();

        }
        public void envio_impuesto() // funcion principal
        {
            Console.WriteLine("selecciona el precio del producto1");
            decimal producto1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("selecciona el precio del producto2");
            decimal producto2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("selecciona el precio del producto3");
            decimal producto3 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("selecciona el precio del producto4");
            decimal producto4 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("selecciona el precio del producto5");
            decimal producto5 = decimal.Parse(Console.ReadLine());

            decimal valor_de_productos = (producto1 + producto2 + producto3 + producto4 + producto5);
            Console.Clear();

            if (valor_de_productos <= 1999)
            {
                calculo_envioeimpuesto(valor_de_productos, 0.10m, 0.08m); // se llama al metodo y se le dan los argumentos


            }
            else if (valor_de_productos > 2000 && valor_de_productos <= 4999)
            {
                calculo_envioeimpuesto(valor_de_productos, 0.08m, 0.12m);

            }
             else if (valor_de_productos >= 5000)
                {
                    calculo_envioeimpuesto(valor_de_productos, 0 , 0.15m);

                }



        }
    }
}
