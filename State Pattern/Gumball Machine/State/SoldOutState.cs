using System;
using GumballMachine.Context;
namespace GumballMachine.State
{
    public class SoldOutState : IState
    {
        private Machine gumballMachine;
        public SoldOutState(Machine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            System.Console.WriteLine("We are sold out. No need to insert a quarter.");
        }

        public void EjectQuarter()
        {
            System.Console.WriteLine("No Quarter was inserted.");
        }

        public void TurnCrank()
        {
            System.Console.WriteLine("Sorry, We are out of gumballs.");
        }

        public void Dispense()
        {
            System.Console.WriteLine("No gumballs to dispense.");
        }
    }
}