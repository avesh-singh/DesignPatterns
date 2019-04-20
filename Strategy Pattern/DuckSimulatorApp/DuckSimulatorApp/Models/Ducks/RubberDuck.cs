using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulatorApp.Models.Ducks
{
    class RubberDuck:Duck
    {
        public RubberDuck()
        {
            Console.WriteLine("A Rubber Duck is manufactured.");
            flyBehaviour = new CannotFly();
            quackBehaviour = new Squeak();
        }
    }
}
