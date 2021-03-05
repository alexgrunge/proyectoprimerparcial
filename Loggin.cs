using System;

namespace proyecto_primer_parcial
{
    class Loggin
    {
        static void Main(string[] args)
        {
            while (true) {
                //login 
                Console.WriteLine("Ingresa el usuario");
                string user = Console.ReadLine();
                Console.WriteLine("Ingresa la contraseña");
                string pass = Console.ReadLine();

                if (user == "ALEX" && pass == "alex") //validacion
                {
                    Console.Clear();
                    Console.WriteLine("Bienvenido " + user + " (pulsa enter para continuar)...");
                    Console.ReadKey();
                    Console.Clear();
                    menu obj = new menu();
                    obj.main_menu();
                }
                else
                {
                    Console.WriteLine("Usuario o contraseña invalidos intenta de nuevo");
                    Console.ReadKey();
                    Console.Clear();
                } 
            

            }
           
        }
    }
}
