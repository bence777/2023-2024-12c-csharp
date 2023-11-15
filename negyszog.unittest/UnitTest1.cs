using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using negyszog;

namespace negyszog.unittest
{
    [TestClass]
    public class NegyszogClass
    {
        [TestMethod]
        public void TeruletTeszt()
        {
            // Arrange - Környezet beállítása
            //Példányosítom az osztályt
            NegyszogClass kr = new NegyszogClass(3);
            kr.setTerulet();

            //Act - Futtatás
            double varteredmeny = 9;
            double kapotteredmeny = Math.Round(kr.getTerulet(), 2);
            //Assert - Kiértékelés
            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }
        [TestMethod]
        public void KeruletTeszt()
        {
            NegyszogClass kr = new NegyszogClass(3);
            kr.setKerulet();
            double varteredmeny = 12;
            double kapotteredmeny = Math.Round(kr.getKerulet(), 2);
            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }
        [TestMethod]
        public void OldalTeszt()
        {
            NegyszogClass kr = new NegyszogClass(3);
            kr.getOldal();
            double varteredmeny = 3;
            double kapotteredmeny = kr.getOldal();
            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }

        [TestMethod]
        public void Oldal2Teszt()
        {
            NegyszogClass kr = new NegyszogClass();
            kr.getOldal2();
            double varteredmeny = 3;
            double kapotteredmeny = kr.getOldal2();
            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }
    }
}
