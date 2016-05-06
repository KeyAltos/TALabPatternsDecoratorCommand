using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskPatternsCommandDecorator.Recievers
{
    public class TwoPointsDistance
    {
        private Point pointOne;
        private Point pointTwo;
        
        public TwoPointsDistance(Point pointOne, Point pointTwo)
        {
            this.pointOne = pointOne;
            this.pointTwo = pointTwo;
        } 

        public void CalculateDistance()
        {
            int sideOne = pointOne.X - pointTwo.X;
            int sideTwo = pointOne.Y - pointTwo.Y;
            var distance = Math.Sqrt(sideOne * sideOne + sideTwo * sideTwo);
            Console.WriteLine("The distance between {0} and {1} is {2:0.000}", pointOne,pointTwo,distance);
        }
    }

    public class Point
    {
        private int x;
        private int y;

        public int X { get { return x; } }
        public int Y { get { return y; } }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return "("+x+", "+y+")";
        }
    }
}
