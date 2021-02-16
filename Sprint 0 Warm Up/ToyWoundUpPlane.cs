using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    class ToyWoundUpPlane : Airplane
    {
        public ToyWoundUpPlane()
        {
            Name = "OOPFlying.ToyPlane";

            CurrentAltitude = 0;

            Isflying = false;

            MaxAltitude = 50;

            Engine.Istarted = false;

            

        }


        bool IsWound = false;

        public override string StartEngine()
        {
            string StartEngines = "";
            
            if (IsWound == true)
            {
                Engine.Istarted = true;

                StartEngines = Name + " is flying";
            }
            else
            {
                Engine.Istarted = false;

                StartEngines = Name + "is not flying, because it is not wound up";
            }

            return StartEngines;
        }

        public string windUp()
        {
            IsWound = true;

            string Winder = "";

            Winder = Name + " has been wounded up";

            return Winder;


        }

    }
}
