using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab1
{
    public class Point
    {
        public double x;
        public double y;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Mi Air, 08.03.2020. </remarks>
        ///
        /// <param name="x">    The x coordinate. </param>
        /// <param name="y">    The y coordinate. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }
        public Point MovePoint(Vector v)
        {
            return new Point(this.x + v.x, this.y + v.y);
        }
        public Point OppositePoint()
        {
            return new Point((-1) * this.x, (-1) * this.y);
        }
        public Point DoublePoint()
        {
            return new Point(2 * this.x, 2 * this.y);
        }
    }
}