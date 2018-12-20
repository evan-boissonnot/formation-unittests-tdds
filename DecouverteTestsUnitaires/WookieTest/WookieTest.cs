using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarWarsLibrairie;

namespace WookieTest
{
    [TestClass]
    public class WookieTest
    {
        [DataTestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("Chewie")]
        [DataRow("Chewieskdjskjdskjdksjdskjdskjdskjdksjdksjd")]
        public void TestCrieDuWookieQuiEstOK(string name)
        {
            Wookie wookie = new Wookie()
            {
                Name = name
            };

            wookie.Crier((crie) =>
            {
                Assert.IsInstanceOfType(crie, typeof(string));
                Assert.IsNotNull(crie);
                string crieQuiEstAttendu = "Le wookie " + name + " crie : ROAAAAAAR !";

                Assert.IsTrue(crie == crieQuiEstAttendu);

            });
            
        }
    }
}
