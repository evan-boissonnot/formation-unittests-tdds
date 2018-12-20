using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonPremierTest;

namespace UnitTestProject1
{
    [TestClass]
    public class VaisseauUnitTest
    {
        [TestMethod]
        public void TestAtterrirFonctionne()
        {
            Vaisseau vaisseau = new Vaisseau();

            vaisseau.AltitudeInitiale = 500;

            //vaisseau.Decoller();
            vaisseau.Atterrir();

            Assert.IsTrue(vaisseau.Altitude == 0, "Ici l'altitude doit être à zéro après avoir atterri");
        }

        [TestMethod]
        public void TestAtterrirNeFonctionnePasSiPasDecollerDabord()
        {
            Vaisseau vaisseau = new Vaisseau();

            vaisseau.AltitudeInitiale = 0;

            Assert.ThrowsException<AltitudeException>(() =>
            {
                vaisseau.Atterrir();
            });
        }

    }
}
