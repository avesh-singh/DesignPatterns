using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulatorApp.Models.Ducks
{
    class MallardDuck:Duck
    {
        public MallardDuck()
        {
            Console.WriteLine("A Mallard Duck is born.");
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new CanQuack();
        }
    }
}
