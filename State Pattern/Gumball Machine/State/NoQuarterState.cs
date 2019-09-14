using System;
using GumballMachine.Context;

namespace GumballMachine.State
{
    public class NoQuarterState : IState
    {
        private Machine gumballMachine;
        public NoQuarterState(Machine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You have inserted a Quarter.");
            gumballMachine.SetState(gumballMachine.GetHasQuarterState());
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Machine has no Quarters!!");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You have turned the crank but I need quarters first.");
        }

        public void Dispense()
        {
            Console.WriteLine("Please insert a Quarter to dispense gumballs.");
        }
    }
}