using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulatorApp.Models.Ducks
{
    class RedheadDuck:Duck
    {
        public RedheadDuck()
        {
            Console.WriteLine("A Redhead Duck is born.");
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new Squeak();
        }
    }
}
