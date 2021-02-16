using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    class AirPort
    {

        int MaxVehicles = 0;

        List<AerialVehicle> Vehicle = new List<AerialVehicle>();



        public string AirPortCode { get; set; }

        public string Airports(string Code)
        {

            string Check;
            if (Code == "delta13")
            {
                Check = "Access Granted";


                AirPortCode = Code;
            }
            else
            {
                Check = "Access NOTGranted";
            }

            return Check;
        }


        public string AirpotMax(int max)
        {
            string confirmedQuestionMark = "Inncorrect access codes";

            if (AirPortCode == "delta13")
            {
            MaxVehicles = max;


            confirmedQuestionMark = max + "Confirmed";

            }

           
            return confirmedQuestionMark;
        }

        public void AddtoPort(AerialVehicle a)
        {
            Vehicle.Add(a);
        }

        public void Land(AerialVehicle a)
        {
            if (a.Isflying == false && Vehicle.Count < MaxVehicles)
            {
                a.StopEngine();
                Vehicle.Add(a);
            }
        }

        public void LandAll(List <AerialVehicle> Landing)
        {
            for (int i = 0; i < Landing.Count; i++)
            {
                
                Landing[i].StopEngine();
                Vehicle.Add(Landing[i]);
            }
        }

        public string Takeoff(AerialVehicle a)
        {

            a.TakeOff();

            return a.Name + " has taken off";
        }

        public string AllTakeOff()
        {

            for (int i = 0; i < Vehicle.Count; i++)
            {
                Vehicle[i].TakeOff();
            }

            return "All Planes with engines on have taken off";
        }

        public string AllStartEngine()
        {

            for (int i = 0; i < Vehicle.Count; i++)
            {
                Vehicle[i].StartEngine();
            }

            return "All Planes have Started engine";
        }

    }
}
