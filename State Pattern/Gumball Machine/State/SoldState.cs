using System;
using GumballMachine.Context;
namespace GumballMachine.State
{
    public class SoldState : IState
    {
        private Machine gumballMachine;
        public SoldState(Machine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            System.Console.WriteLine("Please wait, we are dispensing a gumball.");
        }

        public void EjectQuarter()
        {
            System.Console.WriteLine("You have already turned the crank. You cannot take the quarter back!!");
        }

        public void TurnCrank()
        {
            System.Console.WriteLine("Turning twice doesn't get you another gumball!");
        }

        public void Dispense()
        {
            gumballMachine.releaseGumball();
            if (gumballMachine.getCount() > 0)
            {
                gumballMachine.SetState(gumballMachine.GetNoQuarterState());
            }
            else
            {
                System.Console.WriteLine("Oops, out of gumballs!!");
                gumballMachine.SetState(gumballMachine.GetSoldOutState());
            }
        }
    }
}