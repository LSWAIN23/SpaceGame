using System;

namespace SpaceGame
{
    public class Coordinate
    {
        private double x, y;

        public Coordinate()
        {
            this.x = -1;
            this.y = -1;
        }

        public Coordinate(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double DistanceTo(Coordinate destination)
        {
            double xDiff = this.x - destination.x;
            double yDiff = this.y - destination.y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }
    }
}
