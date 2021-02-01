using System;

namespace Sprint_0_Warm_Up
{
    public abstract class AerialVehicle
    {
        public string Name { get; set; }

        public int CurrentAltitude { get; set; }

        public bool Isflying { get; set; }

        public int MaxAltitude { get; set; }

        Engine Engine { get; set; }

        public AerialVehicle()
        {

        }

        public abstract string About();
        //{
        //throw new NotImplementedException();
        //}

        public abstract string TakeOff();
        //{
        //throw new NotImplementedException();
        //}

        public abstract string StartEngine();
        //{
        //throw new NotImplementedException();
        //}

        public abstract string FlyDown(int howMuch);
        //{
        //throw new NotImplementedException();
        //}

        internal string FlyUp()
        {
            string Flys = "";

            

            if ((CurrentAltitude + 1000) <= MaxAltitude)
            {
                CurrentAltitude = CurrentAltitude + 1000;
            }

            Flys = "This " + Name + ".AerialVehicle has a max altitude of " + MaxAltitude + "ft. \nIts current altitude is " + CurrentAltitude + " ft.\n" + Name + "." + Engine.Abouting();

            return Flys;
     }

    internal abstract string FlyUp(int HowMuch);
        //{
            //throw new NotImplementedException();
        //}
    }
}