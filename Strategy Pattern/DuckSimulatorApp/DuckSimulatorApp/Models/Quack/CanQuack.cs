using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulatorApp.Models
{
    public class CanQuack:QuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Quack!! Quack!!");
        }
    }
}
