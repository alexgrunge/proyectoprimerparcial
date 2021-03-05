using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto_primer_parcial
{
    class menu //clase menu
    {

     
        public void main_menu() //funcion menu principal
        {
            while (true)
            {
                Console.WriteLine("Selecciona una opcion del menu");
                Console.WriteLine("\n1.Calculo de impuesto al iva de un producto \n2.Calculo de comision por recargas \n3:Calculo de envio e impuestos ");
                Console.WriteLine("4.Comprar Boletos de Avion  \n5.Menu de compra de articulos chinos \n6.Compra de Membresias de Gimnasio \n7.Salir");
                int opc = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opc)
                {
                    case 1:  //dependiendo el caso crea un objeto de una clase y manda a llamar su funcion/metodo
                        opc1 obj1 = new opc1();
                        obj1.valor_agregado();
                        break;
                    case 2:
                        opc2 obj2 = new opc2();
                        obj2.comision_recargas();
                      
                        break;
                    case 3:
                        opc3 obj3 = new opc3();
                        obj3.envio_impuesto();
                        
                        break;
                    case 4:
                        opc4 obj4 = new opc4();
                        obj4.boletos_avion();
                        break;
                    case 5:
                        opc5 obj5 = new opc5();
                        obj5.articulos_chinos();
                       
                        break;
                    case 6:
                        opc6 obj6 = new opc6();
                        obj6.membresia_gim();
                        break;
                    case 7:
                        Environment.Exit(1); // cierra el programa
                        break;
                    default:
                        Console.WriteLine("la operacion no es correcta");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }

        }

    }
}
