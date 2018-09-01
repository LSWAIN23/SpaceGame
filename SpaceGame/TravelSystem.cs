using System;

namespace SpaceGame
{
    public static class TravelSystem
    {
        // v (w) = w ^ (10/3) + (10 -w) ^ (-11/3)

        public static double CalculateVelocity(int warpSpeed)
        {
            double velocity = Math.Pow((double)warpSpeed, (10 / 3)) + Math.Pow((10 - warpSpeed), (-11 / 3);
            return velocity;
        }
    }
}