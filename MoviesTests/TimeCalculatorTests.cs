using Microsoft.VisualStudio.TestTools.UnitTesting;
using Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies;

namespace Movies.Tests
{
    [TestClass()]
    public class TimeCalculatorTests
    {
        private TimeCalculator movieClass = new TimeCalculator();
        [TestMethod()]
        public void ConvertMinutesToSecondsTest()
        {
            movieClass.ConvertMinutesToSeconds(-1);
        }
    }
}