using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    class Helicopter : AerialVehicle
    {
        public Helicopter()
        {
            Name = "OOPFlying.Helicopter";

            CurrentAltitude = 0;

            Isflying = false;

            MaxAltitude = 8000;

            Engine.Istarted = false;

        }
    }
}
