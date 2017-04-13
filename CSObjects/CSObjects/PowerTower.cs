using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSObjects
{
    class PowerTower : Tower
    {
        protected override int Power { get; } = 2;

        public PowerTower(MapLocation location) : base(location)
        {

        }
    }
}
