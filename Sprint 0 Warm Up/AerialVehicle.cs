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

        public virtual string About()
        {
            string Abouts = "";

            Abouts = "This " + Name + " has a max altitude of " + MaxAltitude + "ft.\n Its currently at a altitude of " + CurrentAltitude + " ft.\n" + Name + "." + Engine.Abouting();

            return Abouts;
        }
        //{
        //throw new NotImplementedException();
        //}

        public virtual string TakeOff()
        {
            string TakeOffs = "";

            TakeOffs = Name + " can fly its " + Engine.Abouting();

            return TakeOffs;
        }
        //{
        //throw new NotImplementedException();
        //}

        public virtual string StartEngine()
        {
            string StartEngines = "";

            Engine.Istarted = true;

            StartEngines = Name + " is flying";

            Isflying = true;

            return StartEngines;
        }
        //{
        //throw new NotImplementedException();
        //}

        public virtual string StopEngine()
        {
            string StartEnginese = "";


            if (CurrentAltitude <= 0)
            {
                Engine.Istarted = false;

                StartEnginese = Name + " has sussesfully landed safely";
            }
            else if (CurrentAltitude <= 20)
            {
                Engine.Istarted = false;

                StartEnginese = Name + " landed, but brused";
            }
            else if (CurrentAltitude <= 25)
            {
                Engine.Istarted = false;

                StartEnginese = Name + " landedishly, but Your the only survior";
            }
            else
            {
                Engine.Istarted = false;

                StartEnginese = Name + " fell and crashed";
            }

            Isflying = false;

            return StartEnginese;
        }

        public virtual string FlyDown(int howMuch)
        {
            string Flys = "";

            if ((CurrentAltitude + howMuch) <= MaxAltitude && (CurrentAltitude - howMuch >= 0))
            {
                CurrentAltitude = CurrentAltitude - howMuch;
            }

            Flys = "This " + Name + " has a max altitude of " + MaxAltitude + "ft. \nIts current altitude is " + CurrentAltitude + " ft.\n" + Name + "." + Engine.Abouting();

            return Flys;
        }
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

            Flys = "This " + Name + " has a max altitude of " + MaxAltitude + "ft. \nIts current altitude is " + CurrentAltitude + " ft.\n" + Name + "." + Engine.Abouting();

            return Flys;
        }

    internal virtual string FlyUp(int HowMuch)
        {
            string Flys = "";

            if ((CurrentAltitude - HowMuch) <= MaxAltitude && (CurrentAltitude - HowMuch >= 0))
            {
                CurrentAltitude = CurrentAltitude + HowMuch;
            }

            Flys = "This " + Name + " has a max altitude of " + MaxAltitude + "ft. \nIts current altitude is " + CurrentAltitude + " ft.\n" + Name + "." + Engine.Abouting();

            return Flys;
        }
    
        //{
            //throw new NotImplementedException();
        //}
    }
}