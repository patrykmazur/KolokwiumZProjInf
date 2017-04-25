using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumZProjInf
{
    public class Rectangle
    {
        private Point point;

        private List<string> rectPoints;

        public List<string> DrawRectangleCartesian(Point startPoint, int length)
        {
            throw new NotImplementedException();
        }

        public List<string> DrawFirstSide(Point startPoint, int length)
        {
            Point methodPoint = new Point(startPoint.GetX(), startPoint.GetY());
            List<string> side = new List<string>();
            for (int i = startPoint.GetX(); i <= startPoint.GetX() + 5; i++)
            {
                methodPoint.setX(i);
                methodPoint.setY(startPoint.GetY());
                side.Add(methodPoint.CartesianCoordinates());
            }

            return side;
        }

        public List<string> DrawSecondSide(Point startPoint, int length) {throw new NotImplementedException(); }
        public List<string> DrawThirdSide(Point startPoint, int length) {throw new NotImplementedException(); }
        public List<string> DrawFourthSide(Point startPoint, int length) { throw new NotImplementedException();}

    }
}
