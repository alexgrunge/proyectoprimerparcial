using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto_primer_parcial
{
    class opc4
    {
        public void boletos_avion() //funcion principal
        {
            Console.WriteLine("selecciona una opcion \n1.Standar($1100) \n2.Primera clase($1500)");
            int opc = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opc)
            {
                case 1: // si se escoge el boleto standar
                    int boletos = 1100;
                    decimal suma = 0m;
                    Console.WriteLine(" \nBOLETO STANDAR \nCuantos boletos desea? ");
                    int cuantos = int.Parse(Console.ReadLine());
                    for (int i = 0; i <= 0; i++)
                    {

                        Console.WriteLine("cuanto pesa tu equipaje? (el de todos tus boletos)");
                        decimal equipaje = decimal.Parse(Console.ReadLine());
                        if (equipaje > 10) // si el equipaje pesa mas de 10kg
                        {
                            decimal mayorequipaje = equipaje / 10; //logica del incremento del impuesto segun el equipaje

                            decimal impequipaje = boletos * 0.05m;
                            impequipaje = mayorequipaje * 0.05m;
                            impequipaje = boletos * impequipaje;
                            impequipaje = impequipaje + boletos;
                            suma = suma + impequipaje;

                            decimal impuesto_tua = suma * 0.25m; //los demas impuestos agregados
                            suma = suma + impuesto_tua;
                            decimal iva = suma * 0.16m;
                            suma = suma + iva;
                            suma = suma * cuantos;
                            Console.WriteLine("el precio de tu boleto es de: " + boletos);
                            Console.WriteLine("la cantidad de boletos es de: " + cuantos);
                            Console.WriteLine("el precio por todos los boletos es de: " + boletos * cuantos);
                            Console.WriteLine("el impuesto TUA es del: 25% " + "\nEl impuesto del iva es del 16% \nEl impuesto total de equipaje es de: " + impequipaje+ " aumenta 5% por cada 10 kilos");
                        }
                        else if (equipaje == 10)
                        {
                            decimal impequipaje = boletos * 0.05m; //si pesa igual a 10 kg
                            impequipaje = boletos + impequipaje;
                            suma = suma + impequipaje;
                            decimal impuesto_tua = suma * 0.25m;
                            suma = suma + impuesto_tua;
                            decimal iva = suma * 0.16m;
                            suma = suma + iva;
                            suma = suma * cuantos;
                            Console.WriteLine("el precio de tu boleto es de: " + boletos);
                            Console.WriteLine("la cantidad de boletos es de: " + cuantos);
                            Console.WriteLine("el precio por todos los boletos es de: " + boletos * cuantos);
                            Console.WriteLine("el impuesto TUA es del: 25% " + "\nEl impuesto del iva es del 16% \nEl impuesto total de equipaje  es de: " + impequipaje + " aumenta 5% por cada 10 kilos");

                        }

                        else
                        {
                            // si es menor a 10 kg

                            decimal impuesto_tua = boletos * 0.25m;
                            suma = boletos + impuesto_tua;
                            decimal iva = suma * 0.16m;
                            suma = suma + iva;
                            suma = suma * cuantos;

                            Console.WriteLine("el precio de tu boleto es de: " + boletos);
                            Console.WriteLine("la cantidad de boletos es de: " + cuantos);
                            Console.WriteLine("el precio por todos los boletos es de: " + boletos * cuantos);
                            Console.WriteLine("el impuesto TUA es del: 25% " + "\nEl impuesto del iva es del 16% \nNo hay impuesto por equipaje" );


                        }



                    }
                    Console.WriteLine("el total a pagar es es " + "$" + suma);
                    Console.ReadKey();
                    Console.Clear();
                   break;

                case 2: // si se escoge el boleto de primera clase
                    boletos = 1500;
                    suma = 0m;
                    Console.WriteLine(" \nBOLETO PRIMERA CLASE \nCuantos boletos desea? ");
                     cuantos = int.Parse(Console.ReadLine());
                    for (int i = 0; i <= 0; i++)
                    {

                        Console.WriteLine("cuanto pesa tu equipaje? (el de todos tus boletos)");
                        decimal equipaje = decimal.Parse(Console.ReadLine());
                        if (equipaje > 10)
                        {
                            decimal mayorequipaje = equipaje / 10;

                            decimal impequipaje = boletos * 0.05m;
                            impequipaje = mayorequipaje * 0.05m;
                            impequipaje = boletos * impequipaje;
                            impequipaje = impequipaje + boletos;
                            suma = suma + impequipaje;
                            decimal impuesto_tua = suma * 0.25m;
                            suma = suma + impuesto_tua;
                            decimal iva = suma * 0.16m;
                            suma = suma + iva;
                            suma = suma * cuantos;
                            Console.WriteLine("el precio de tu boleto es de: " + boletos);
                            Console.WriteLine("la cantidad de boletos es de: " + cuantos);
                            Console.WriteLine("el precio por todos los boletos es de: " + boletos * cuantos);
                            Console.WriteLine("el impuesto TUA es del: 25% " + "\nEl impuesto del iva es del 16% \nEl impuesto total de equipaje es de: " + impequipaje + " aumenta 5% por cada 10 kilos");

                        }
                        else if (equipaje == 10)
                        {
                            decimal impequipaje = boletos * 0.05m;
                            impequipaje = boletos + impequipaje;
                            suma = suma + impequipaje;
                            decimal impuesto_tua = suma * 0.25m;
                            suma = suma + impuesto_tua;
                            decimal iva = suma * 0.16m;
                            suma = suma + iva;
                            suma = suma * cuantos;
                            Console.WriteLine("el precio de tu boleto es de: " + boletos);
                            Console.WriteLine("la cantidad de boletos es de: " + cuantos);
                            Console.WriteLine("el precio por todo los boletos es de: " + boletos * cuantos);
                            Console.WriteLine("el impuesto TUA es del: 25% " + "\nEl impuesto del iva es del 16% \nEl impuesto total de equipaje" +
                                " es de: " + impequipaje + " aumenta 5% por cada 10 kilos");

                        }

                        else
                        {

                            decimal impuesto_tua = boletos * 0.25m;
                            suma = boletos + impuesto_tua;
                            decimal iva = suma * 0.16m;
                            suma = suma + iva;
                            suma = suma * cuantos;
                            Console.WriteLine("el precio de tu boleto es de: " + boletos);
                            Console.WriteLine("la cantidad de boletos es de: " + cuantos);
                            Console.WriteLine("el precio por todos los boletoses de: " + boletos * cuantos);
                            Console.WriteLine("el impuesto TUA es del: 25% " + "\nEl impuesto del iva es del 16% \nNo hay impuesto por equipaje");



                        }



                    }
                    Console.WriteLine("el total a pagar es es " + "$" + suma);
                    Console.ReadKey();
                    Console.Clear();
                    break;

                default:
                        Console.WriteLine("no es una opcion valida");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    
            }

           

        }

        }
    }
