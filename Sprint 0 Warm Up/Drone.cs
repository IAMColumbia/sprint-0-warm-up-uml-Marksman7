using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    class Drone : AerialVehicle
    {
        public Drone()
        {
            Name = "OOPFlying.Drone";

            CurrentAltitude = 0;

            Isflying = false;

            MaxAltitude = 500;

            Engine.Istarted = false;

        }


        public Drone(string Name, int CurrentAltitude, bool Isflying, int MaxAtitude)
        {
            this.Name = Name;
            this.CurrentAltitude = CurrentAltitude;
            this.Isflying = Isflying;
            this.MaxAltitude = MaxAltitude;
        }
    }
}
