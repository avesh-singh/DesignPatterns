using System;
using GumballMachine.Context;
using GumballMachine.State;

namespace Gumball_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            Machine gumballMachine = new Machine(10);

            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();
            System.Console.WriteLine();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            System.Console.WriteLine();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.EjectQuarter();
            System.Console.WriteLine();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            System.Console.WriteLine();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            System.Console.WriteLine();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();          
        }
    }
}
