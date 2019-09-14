using System;
using GumballMachine.Context;
namespace GumballMachine.State
{
    public class WinnerState : IState
    {
        private Machine gumballMachine;
        public WinnerState(Machine gumballMachine)
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
            System.Console.WriteLine("You are a winner!! You get two gumballs for a quarter.");
            gumballMachine.releaseGumball();
            if (gumballMachine.getCount() > 0)
            {
                gumballMachine.releaseGumball();
                if (gumballMachine.getCount() > 0)
                {
                    gumballMachine.SetState(gumballMachine.GetNoQuarterState());
                }
                else
                {
                    gumballMachine.SetState(gumballMachine.GetSoldOutState());
                }
            }
            else
            {
                System.Console.WriteLine("Oops, out of gumballs!!");
                gumballMachine.SetState(gumballMachine.GetSoldOutState());
            }
        }
    }
}