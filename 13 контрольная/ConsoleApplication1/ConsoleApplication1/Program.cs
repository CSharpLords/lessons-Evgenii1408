using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какую вещь ты хочешь найти");
            Console.WriteLine("носки");
            Console.WriteLine("портфель");
            Console.WriteLine("тапочки");
            Console.WriteLine("Xbox");
            Console.WriteLine("телефон");
            Console.WriteLine("записка с паролем от Dota2");
            
            string thing = Console.ReadLine();
            if (thing == "носки"){
                Console.WriteLine("В ванной");
                Console.ReadLine();
            }
            else if (thing == "портфель"){
                Console.WriteLine(" в школе");
                Console.ReadLine();
            }
            else if (thing == "тапочки")
            {
                Console.WriteLine("У бабушки на даче");

                Console.ReadLine();
            }

            else if (thing == "xbox")
            {
                Console.WriteLine("В мусорке");
                Console.ReadLine();
            }
            else if (thing == "телефон")
            {

                Console.WriteLine("У директора");
                Console.ReadLine();

            }

            else if (thing == "Записка с паролем от Dota2")
            {
                Console.WriteLine("У VALVE");
                Console.ReadLine();
            }

            else
            {

                Console.WriteLine("Эту вещь я не знаю");
                Console.ReadLine();
            }



            
            
        
        }
    }
    }
