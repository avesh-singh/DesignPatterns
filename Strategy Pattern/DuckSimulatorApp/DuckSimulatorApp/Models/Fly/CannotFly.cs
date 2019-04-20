using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulatorApp.Models
{
    class CannotFly:FlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Cannot Fly T_T");
        }
    }
}
