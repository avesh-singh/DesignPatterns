using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckSimulatorApp.Models;
using DuckSimulatorApp.Models.Ducks;

namespace DuckSimulatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RunDuckApp();
        }

        static void RunDuckApp()
        {
            Duck duck = CreateDuck();
            if (duck == null)
            {
                return;
            }
            else
            {
                PerformActions(duck);
                Console.ReadKey();
            }
        }

        static Duck CreateDuck()
        {
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("This is a simple Duck Simulator");
            Console.WriteLine("Type:");
            Console.WriteLine("1 for new Mallard Duck");
            Console.WriteLine("2 for new Redhead Duck");
            Console.WriteLine("3 for new Rubber Duck");
            Console.WriteLine("0 to exit the application");
            int.TryParse(Console.ReadLine(), out int duckType);
            switch (duckType)
            {
               
                case 1:
                    return new MallardDuck();
                case 2:
                    return new RedheadDuck();
                case 3:
                    return new RubberDuck();
                case 0:
                default:
                    return null;
            }
        }

        static void PerformActions(Duck duck)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Type to make duck  perform some action:");
            Console.WriteLine("1 for display");
            Console.WriteLine("2 for make it fly");
            Console.WriteLine("3 for make it Swim");
            Console.WriteLine("4 for make it Quack");
            Console.WriteLine("0 to go Back");
            while (true)
            {
                int.TryParse(Console.ReadLine(), out int perform);
                switch (perform)
                {
                    case 0:
                        RunDuckApp();
                        return;
                    case 1:
                        duck.Display();
                        break;
                    case 2:
                        duck.performFly();
                        break;
                    case 3:
                        duck.Swim();
                        break;
                    case 4:
                        duck.performQuack();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
