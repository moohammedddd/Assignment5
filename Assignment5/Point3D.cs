using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point3D(int _x, int _y, int _z)
        {
            X = _x;
            Y = _y;
            Z = _z;
        }

        override public string ToString()
        {
            return $" Point Coordinates: ({X}, {Y}, {Z})";
        }

        public static bool operator ==(Point3D p1, Point3D p2)
        {
            return p1?.X == p2?.X && p1?.Y == p2?.Y && p1?.Z == p2?.Z;

        }

        public static bool operator !=(Point3D p1, Point3D p2)
        {
            //if (p1?.X != p2?.X && p1?.Y != p2?.Y && p1?.Z != p2?.Z)
            //{
            return p1?.X != p2?.X && p1?.Y != p2?.Y && p1?.Z != p2?.Z;
            //}

        }



    }
}
