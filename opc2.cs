using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto_primer_parcial
{
    class opc2
    {


        static void tarifa() // funcion con la logica del modulo
        {
            while (true)
            {


                Console.WriteLine("digita tu numero de telefono");
                string numero = Console.ReadLine();
                Console.WriteLine("confirma el numero tu numero de telefono");
                string numero2 = Console.ReadLine();
                if (numero == numero2)
                {
                    Console.WriteLine("pulsa una tecla para continuar");
                    Console.ReadKey();
                    Console.WriteLine("selecciona el monto \n1.$20 \n2.$50 \n3.$100 \n4.$200 \n5.$400");
                    int monto = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (monto == 100)
                    {
                        decimal monto_total = monto * 0.02m;
                        monto_total = monto_total + monto;
                        Console.WriteLine("\n Numero de telefono: " + numero + "\n El impuesto es de 2% " + "\nEl total a pagar es de: " + monto_total);
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (monto == 200)
                    {
                        decimal monto_total = monto * 0.03m;
                        monto_total = monto_total + monto;
                        Console.WriteLine("\n Numero de telefono: " + numero + "\n El impuesto es de 3% " + "\nEl total a pagar es de: " + monto_total);
                        Console.ReadKey();
                        Console.Clear();
                    }
                   
                    else if (monto == 400)
                    {
                        decimal monto_total = monto * 0.05m;
                        monto_total = monto_total + monto;
                        Console.WriteLine("\n Numero de telefono: " + numero + "\n El impuesto es de 5% " + "\nEl total a pagar es de: " + monto_total);
                        Console.ReadKey();
                        Console.Clear();
                       
                    }
                   

                    else if (monto < 100)
                    {
                        Console.WriteLine("\n Numero de telefono: " + numero + "\n El impuesto es de 0% " + "\nEl total a pagar es de: " + monto);
                        Console.ReadKey();
                        Console.Clear();
                     

                    }
                    break;

                }
                else
                {
                    Console.WriteLine("los numeros no son correctos intenta de nuevo");
                    Console.ReadLine();
                    Console.Clear();
                }




            }
        }
        public void comision_recargas() // funcion principal
        {
            Console.WriteLine(" selecciona la compañia: \n1.Telcel \n2.Movistar \n3.At&t ");
            int opc_compañia = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opc_compañia)
            {
                case 1:
                    Console.WriteLine("Telcel");
                    tarifa();
                    break;
                    
                case 2:
                    Console.WriteLine("Movistar");
                    tarifa();
                    break;
                case 3:
                    Console.WriteLine("At&t");
                    tarifa();
                    break;
                default:
                    Console.WriteLine("valor invalido");
                    Console.ReadKey();
                    Console.Clear();
                    break;
               
            }
        }

    }
}
