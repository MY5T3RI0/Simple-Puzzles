using Microsoft.VisualStudio.TestTools.UnitTesting;
using Puzzles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tests
{
    [TestClass()]
    public class PersistenceTest
    {
        [TestMethod()]
        public void Test1()
        {
            Console.WriteLine("****** Basic Tests");
            Assert.AreEqual(3, NumberPuzzles.Persistence(39));
            Assert.AreEqual(0, NumberPuzzles.Persistence(4));
            Assert.AreEqual(2, NumberPuzzles.Persistence(25));
            Assert.AreEqual(4, NumberPuzzles.Persistence(999));
        }
    }
}