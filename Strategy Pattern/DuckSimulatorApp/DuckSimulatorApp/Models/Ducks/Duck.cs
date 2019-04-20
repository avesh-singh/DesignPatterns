using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulatorApp.Models
{
    public class Duck
    {
        protected FlyBehaviour flyBehaviour;
        protected QuackBehaviour quackBehaviour;
        public Duck()
        {
            Console.WriteLine("Creating a Duck");
        }

        public void Display()
        {
            Console.WriteLine("Looks like a Duck");
        }

        public void performFly()
        {
            flyBehaviour.Fly();
        }

        public void performQuack()
        {
            quackBehaviour.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All Ducks can swim, or atleat float");
        }
    }
}
