using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
               
                Console.WriteLine("Alegeți opțiunea (C->F sau F->C): ");
                string optiune = Console.ReadLine();

                
                Console.WriteLine("Introduceți temperatura: ");
                float temperatura;
                try
                {
                    temperatura = float.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Valoare invalidă. Introduceți un număr.");
                    continue;
                }

                double CelsiusToFahrenheit;
                Conversie_Grade ob = new Conversie_Grade();
                double FahrenheitToCelsius;
                float temperaturaConv;
                string unitateConv;

                switch (optiune)
                {
                    case "C->F":
                        temperaturaConv = ob.CelsiusToFahrenheit(temperatura);
                        unitateConv = "°F";
                        break;
                    case "F->C":
                        temperaturaConv = ob.FahrenheitToCelsius(temperatura);
                        unitateConv = "°C";
                        break;
                    default:
                        Console.WriteLine("Opțiune invalidă. Alegeți C->F sau F->C.");
                        continue;
                }

               
                Console.WriteLine("Rezultatul conversiei este egal cu: " + temperaturaConv);

               
            }
        }
    }
    }

