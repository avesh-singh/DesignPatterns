using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulatorApp.Models
{
    class Squeak:QuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Qua... Squeak! Squeak! Squeak");
        }
    }
}
