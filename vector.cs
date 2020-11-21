using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    public struct Vector
    {
	    x = X;
            y = Y;
            z = Z;
		
        public Vector(double X, double Y, double Z) 
		{
			return (x, y, z) = (X, Y, Z);
		}

        public override string ToString() 
		{	
			return $"({x}, {y}, {z})";
		}

        public static Vector operator +(Vector a, Vector b)
		{
			 return new Vector(a.x + b.x, a.y + b.y, a.z + b.z);
		}

        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        public static Vector operator *(Vector a, Vector b)
        {
            return new Vector(a.x * b.x, a.y * b.y, a.z * b.z);
        }

        public static Vector operator *(Vector a, int p)
        {
            return new Vector(a.x * p, a.y * p, a.z * p);
        }

        public static Vector operator  / (Vector a, int p)
        {
            return new Vector(a.x / p, a.y / p, a.z / p);
        }

        public Vector Normalize()
        {
            double n = Math.Sqrt(x * x + y * y + z * z);
            return new Vector(x / n, y / n, z / n);
        }

        public double GetLength()
        {
            double q = Math.Sqrt(x * x + y * y + z * z);
            return q;
        }
    }
}
