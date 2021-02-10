using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    public class Airplane : AerialVehicle
    {
        public Airplane()
        {
            Name = "OOPFlying.Airplane";

            CurrentAltitude = 0;

            Isflying = false;

            MaxAltitude = 41000;

            Engine.Istarted = false;

        }

        public override string About()
        {
            string Abouts = "";

                Abouts = "This " + Name + " has a max altitude of " + MaxAltitude + "ft.\n Its currently at a altitude of " + CurrentAltitude + " ft.\n" + Name + "." + Engine.Abouting();

            return Abouts;
        }

        public override string TakeOff()
        {
            string TakeOffs = "";

                TakeOffs = Name + " can fly its " + Engine.Abouting();

            return TakeOffs;
        }

        public override string StartEngine()
        {
            string StartEngines = "";

            Engine.Istarted = true;

            StartEngines = Name + " is flying";

            return StartEngines;
        }

        public override string FlyDown(int howMuch)
        {
            string Flys = "";

            if ((CurrentAltitude + howMuch) <= MaxAltitude && (CurrentAltitude - howMuch >= 0))
            {
                CurrentAltitude = CurrentAltitude - howMuch;
            }

            Flys = "This " + Name + " has a max altitude of " + MaxAltitude + "ft. \nIts current altitude is " + CurrentAltitude + " ft.\n" + Name + "." + Engine.Abouting();

            return Flys;
        }

        internal override string FlyUp(int HowMuch)
        {
            string Flys = "";

            if ((CurrentAltitude - HowMuch) <= MaxAltitude && (CurrentAltitude - HowMuch >= 0))
            {
                CurrentAltitude = CurrentAltitude + HowMuch;
            }

            Flys = "This " + Name + " has a max altitude of " + MaxAltitude + "ft. \nIts current altitude is " + CurrentAltitude + " ft.\n" + Name + "." + Engine.Abouting();

            return Flys;
        }

    }
}
