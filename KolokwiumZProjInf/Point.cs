using System;

namespace KolokwiumZProjInf
{
    public class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public string CartesianCoordinates()
        {
            return $"({x},{y})";
        }

        public string PolarCoordinates()
        {
            throw new NotImplementedException();
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }
    }


}