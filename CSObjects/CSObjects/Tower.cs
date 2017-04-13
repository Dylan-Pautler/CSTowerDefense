using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSObjects
{
    class Tower
    {
        protected virtual int Range { get; } = 1;

        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;

        

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        private bool IsSuccessfulShot()
        {
            return Random.NextDouble() < Accuracy;
        }

        public void FireOnInvaders(IInvader[] invaders)
        {
            foreach(IInvader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(Power);
                        Console.WriteLine("Shot at and hit an invader!");
                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized an invader at " + invader.Location + "!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shot at and missed an invader");
                    }
                    break;
                }
            }
        }
    }

}
