using System;
using System.Diagnostics;
using GumballMachine.Context;
namespace GumballMachine.State
{
    public class HasQuarterState : IState
    {
        Random randomWinner = new Random();
        private Machine gumballMachine;
        public HasQuarterState(Machine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            System.Console.WriteLine("You cannot insert another quarter.");
        }

        public void EjectQuarter()
        {
            System.Console.WriteLine("Here is the quarter you inserted...");
            gumballMachine.SetState(gumballMachine.GetNoQuarterState());
        }

        public void TurnCrank()
        {
            System.Console.WriteLine("You turned....");
            if (Math.Round(randomWinner.NextDouble()*10) % 3 == 0)
            {
                gumballMachine.SetState(gumballMachine.GetWinnerState());
            }
            else
            {
                gumballMachine.SetState(gumballMachine.GetSoldState());
            }
        }

        public void Dispense()
        {
            System.Console.WriteLine("No gumball dispensed");
        }
    }
}