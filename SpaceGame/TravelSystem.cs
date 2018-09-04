using System;


namespace SpaceGame
{
    public static class TravelSystem
    {
        internal static double CalculateVelocity(int warpSpeed)
        {
            double velocity = Math.Pow((double)warpSpeed, (10 / 3)) + Math.Pow((10 - warpSpeed), (-11 / 3));
            return velocity;
        }
       
        public static double CalculateTime(double distance, double velocity)
        {
            double FlightTime = (distance / velocity);
            return FlightTime;
        }

        internal static int CalculateFuel()
        {
            int FuelUnits = 0;
            int distance = 0;
            if (distance == 10)
            {
                FuelUnits--;
               
            }
            return FuelUnits;
        }
    }
}