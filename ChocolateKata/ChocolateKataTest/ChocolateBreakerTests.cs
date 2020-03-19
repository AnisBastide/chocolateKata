using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChocolateKata;
using NUnit.Framework;

namespace ChocolateKataTest
{
    public class ChocolateBreakerTests
    {
        [TestFixture]
        public class SolutionTest
        {
            [Test]
            public void TestWithColumnOrLineIsOne()
            {
                var chocolate = new ChocolateBreaker();
                Assert.AreEqual(2, chocolate.BreakChocolateAlgo(1, 3));
                chocolate = new ChocolateBreaker();
                Assert.AreEqual(2, chocolate.BreakChocolateAlgo(3, 1));
            }

            [Test]
            public void NoBreakNeeded()
            {
                var chocolate = new ChocolateBreaker();
                Assert.AreEqual(0, chocolate.BreakChocolateAlgo(1, 1));
            }

            [Test]
            public void FiveBreaks()
            {
                var chocolate = new ChocolateBreaker();
                Assert.AreEqual(5, chocolate.BreakChocolateAlgo(3, 2));
            }

            [Test]
            public void TwentyFourBreaks()
            {
                var chocolate = new ChocolateBreaker();
                Assert.AreEqual(24, chocolate.BreakChocolateAlgo(5, 5));
            }
        }
    }
}
