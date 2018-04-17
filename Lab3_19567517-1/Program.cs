using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_19567517_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            
            Console.Write("Saludos, que opción es la que desea emplear");
            Console.Write("+ Arrendar" + "\n" + "+ Recibir" + "\n" + "+ Salir" + "\n");
            Console.Write("Seleccione una opción: ");
            string op,
            op= Console.ReadLine();
            this.ciclo = true;
            while (ciclo)
            {
                if (op == "Arrendar")
                { 
                    Console.WriteLine("¿Desea una corrida de asientos extra? (Responda si o no)");
                    resp1 = Console.ReadLine();
                    Console.WriteLine("¿Desea un maletero más grande? (Responda si o no)");
                    resp2 = Console.ReadLine();
                    Console.WriteLine("¿Desea un reproductor de DVD? (Responda si o no)");
                    resp3 = Console.ReadLine();
                    if (resp1== "si")
                    {

                    }
                    if (resp1== "no")
                    {

                    }
                    if (resp2== "si")
                    {

                    }
                    if (resp2== "no")
                    {

                    }
                    if (resp3== "si")
                    {

                    }
                    else
                    {

                    }
                }

                if (op == "Recibir")
                {

                }

                else
                {
                    this.ciclo = false;
                    break;
                }

            }
            

            Console.Beep();//La consola realiza el sonido beep)// 
            
             
            Console.ReadKey();
        }
    }
}
