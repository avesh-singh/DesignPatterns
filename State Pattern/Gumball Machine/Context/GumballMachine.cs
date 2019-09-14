using System;
using GumballMachine.State;

namespace GumballMachine.Context
{
    public class Machine
    {
        private IState soldOutState;
        private IState noQuarterState;
        private IState hasQuarterState;
        private IState soldState;
        private IState winnerState;
        private IState state;
        private int count = 0;

        public Machine(int gumballs)
        {
            count = gumballs;
            soldOutState = new SoldOutState(this);
            hasQuarterState = new HasQuarterState(this);
            noQuarterState = new NoQuarterState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);
            if (gumballs > 0)
            {
                this.SetState(noQuarterState);
            }
            else
            {
                this.SetState(soldOutState);
            }
        }

        public void InsertQuarter()
        {
            state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            state.EjectQuarter();
        }

        public void TurnCrank()
        {
            state.TurnCrank();
            state.Dispense();
        }

        public void SetState(IState state)
        {
            System.Console.WriteLine(state);
            this.state = state;
        }

        public IState GetNoQuarterState()
        {
            return noQuarterState;
        }

        public IState GetHasQuarterState()
        {
            return hasQuarterState;
        }

        public IState GetSoldOutState()
        {
            return soldOutState;
        }

        public IState GetSoldState()
        {
            return soldState;
        }

        public IState GetWinnerState()
        {
            return winnerState;
        }

        public void releaseGumball()
        {
            if (count > 0)
            {
                System.Console.WriteLine("A gumball comes rolling into the slot.");
                count--;
            }
        }

        public int getCount()
        {
            return count;
        }
    }
}