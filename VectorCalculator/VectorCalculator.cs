using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorCalculator
{
    public class VectorCalculator
    {


        public Vector AddVectors(Vector v1, Vector v2)
        {
            Vector v = new Vector();
            
            v.X = v1.X + v2.X;
            v.Y = v1.Y + v2.Y;
            
            return v;
        }


        public Vector ScaleVector(Vector v, double a)
        {
            Vector resultantVector = new Vector {X = v.X * a, Y = v.Y * a};
            
            return resultantVector;
        }

        public double DotProduct(Vector v1, Vector v2)
        {
            double dotProduct = v1.X * v2.X + v1.Y * v2.Y;

            return dotProduct;
        }

        public double MagnitudeOfVector(Vector v)
        {
            double magnitude = Math.Sqrt(Math.Pow(v.X, 2) + Math.Pow(v.Y, 2));

            return magnitude;
        }

    }
}
