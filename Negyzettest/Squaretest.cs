using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using negyzet;

namespace Negyzettest
{
    [TestClass]
    public class Squaretest
    {
        static double oldal = 2;
        Square objTest = new Square(oldal);

        [TestMethod]
        public void AtmeroTest()
        {
            //Arrange
            double vartEredmeny = Math.Sqrt(8);

            //Act
            double kapottEredmeny = objTest.Atmero();

            //Assert

            Assert.AreEqual(vartEredmeny, kapottEredmeny);

        }
        [TestMethod]
        public void KeruletTest()
        {
            //Arrange
            double vartEredmeny = 8;

            //Act
            double kapottEredmeny = objTest.Kerulet();

            //Assert

            Assert.AreEqual(vartEredmeny, kapottEredmeny);
        }
        [TestMethod]
        public void TeruletTest()
        {
            //Arrange
            double vartEredmeny = 4;

            //Act
            double kapottEredmeny = objTest.Terulet();

            //Assert

            Assert.AreEqual(vartEredmeny, kapottEredmeny);
        }
        [TestMethod]
        public void TerfogatTest()
        {
            //Arrange
            objTest.Magas = 3;
            double vartEredmeny = 12;

            //Act
            double kapottEredmeny = objTest.OszlopTerfogat();

            //Assert

            Assert.AreEqual(vartEredmeny, kapottEredmeny);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void TerfogatHibaTest()
        {
            //Arrange
            objTest.Magas = 3;
            double vartEredmeny = 69;

            //Act
            double kapottEredmeny = objTest.OszlopTerfogat();

            //Assert

            Assert.AreEqual(vartEredmeny, kapottEredmeny);
        }



    }
}
