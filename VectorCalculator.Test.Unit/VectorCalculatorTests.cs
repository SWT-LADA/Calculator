using System;
using NUnit.Framework;

namespace VectorCalculator.Test.Unit
{
    [TestFixture]
    public class VectorCalculatorTests
    {
        private VectorCalculator _vectorCalculator; // Normal konvention for navngivning er her _uut

        [SetUp]
        public void Setup()
        {
            _vectorCalculator = new VectorCalculator();
        }

        
        [Test]
        public void Test_AddVectors_TwoZeroVectors_ZeroVector()
        {
            Vector v1 = new Vector {X = 0.0, Y = 0.0};
            Vector v2 = new Vector {X = 0.0, Y = 0.0};
            Vector vResult = _vectorCalculator.AddVectors(v1, v2);

            Assert.That(vResult.X, Is.EqualTo(0.0));
            Assert.That(vResult.Y, Is.EqualTo(0.0));
        }

        [Test]
        public void Test_AddVectors_TwoPositiveZeroVectors_PositiveVector()
        {
            Vector v1 = new Vector { X = 1.1, Y = 2.0 };
            Vector v2 = new Vector { X = 3.3, Y = 4.0 };
            Vector vResult = _vectorCalculator.AddVectors(v1, v2);

            Assert.That(vResult.X, Is.EqualTo(4.4));
            Assert.That(vResult.Y, Is.EqualTo(6.0));
        }

        // Bør også teste for negative værdier
        // Man bør måske kun teste én ting i en test. Dvs. test for X i en test og test for Y i en anden test


        [TestCase(0.0, 1.0, 1.0, 0.0, 0.0)]
        [TestCase(2.0, 1.0, 1.0, 2.0, 2.0)]
        [TestCase(-2.0, 1.0, 1.0, -2.0, -2.0)]
        [TestCase(2.0, -1.0, -1.0, -2.0, -2.0)]
        [TestCase(-2.0, -1.0, -1.0, 2.0, 2.0)]
        //[TestCase(1/3, 1, 1, 0.33, 0.33)]
        public void Test_ScaleVector(double a, double x, double y, double xResult, double yResult)
        {
            Vector v = new Vector {X = x, Y = y};
            Vector vResult = _vectorCalculator.ScaleVector(v, a);

            Assert.That(vResult.X, Is.EqualTo(xResult).Within(0.1));
            Assert.That(vResult.Y, Is.EqualTo(yResult).Within(0.1));
        }


        [TestCase(1.0, 1.0, 1.0, 1.0, 2.0)]
        [TestCase(1.0, 1.0, -1.0, -1.0, -2.0)]
        [TestCase(0.0, 0.0, 1.0, 1.0, 0.0)]
        public void Test_dotProduct(double x1, double y1, double x2, double y2, double result)
        {
            Vector v1 = new Vector {X = x1, Y = y1};
            Vector v2 = new Vector {X = x2, Y = y2};

            double dotProduct = _vectorCalculator.DotProduct(v1, v2);

            Assert.That(dotProduct - result, Is.LessThan(double.Epsilon));
        }


        [TestCase(3.0, 4.0, 5.0)]
        public void Test_MagnitudeOfVector(double x, double y, double result)
        {
            Vector v = new Vector {X = x, Y = y};

            double magnitude = _vectorCalculator.MagnitudeOfVector(v);

            Assert.That(magnitude - result, Is.LessThan(double.Epsilon));

        }

    }
}
