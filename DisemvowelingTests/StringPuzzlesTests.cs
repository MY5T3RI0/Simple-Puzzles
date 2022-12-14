using Puzzles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tests
{
    [TestClass()]
    public class AlphabetPosition
    {
        [TestMethod()]
        public void SampleTest()
        {
            Assert.AreEqual("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11", StringPuzzles.AlphabetPosition("The sunset sets at twelve o' clock."));
            Assert.AreEqual("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20", StringPuzzles.AlphabetPosition("The narwhal bacons at midnight."));
        }
    }

    [TestClass()]
    public class Disemvoweling
    {
        [TestMethod()]
        public void ShouldRemoveAllVowels()
        {
            Assert.AreEqual("Ths wbst s fr lsrs LL!", StringPuzzles.Disemvowel("This website is for losers LOL!"));
        }

        [TestMethod()]
        public void MultilineString()
        {
            Assert.AreEqual("N ffns bt,\nYr wrtng s mng th wrst 'v vr rd", StringPuzzles.Disemvowel("No offense but,\nYour writing is among the worst I've ever read"));
        }

        [TestMethod()]
        public void OneMoreForGoodMeasure()
        {
            Assert.AreEqual("Wht r y,  cmmnst?", StringPuzzles.Disemvowel("What are you, a communist?"));
        }

    }
}