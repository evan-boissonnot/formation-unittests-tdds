using System;
using Calculations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculationTestUnitaires
{
    [TestClass]
    public class CalculateurUnitTest
    {
        [DataTestMethod]
        [DataRow(1, 0, 1)]
        [DataRow(1, 1, 2)]
        [DataRow(1, 2, 3)]
        [DataRow(1, 3, 4)]
        public void TestAddtionnerQuiFonctionne(int a, int b, int resultAValider)
        {
            Calculateur calculateur = new Calculateur();

            Assert.IsTrue(calculateur.Additionner(a, b) == resultAValider);
        }

        [TestMethod]
        public void TestDiviserGenereUneErreurQuandDenominateurAZero()
        {
            Calculateur calculateur = new Calculateur();

            Assert.ThrowsException<DivideByZeroException>(() =>
           {
               int resultat = calculateur.Diviser(10, 0);
           });
            


        }
    }
}
