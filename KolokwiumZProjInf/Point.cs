﻿using System;

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
            throw new NotImplementedException();
        }

        public string PolarCoordinates()
        {
            throw new NotImplementedException();
        }
    }


}