namespace Sprint_0_Warm_Up
{
    public class Engine
    {
        public static bool Istarted { get; set; }
        
        
        public static string Abouting()
        {
            string Aboutings = "";
            if (Istarted == true)
            {
                Aboutings= "engine is started.";
            }
            else
            {
                Aboutings = "engine is  not started.";
            }

            return Aboutings;
        }
    }
}