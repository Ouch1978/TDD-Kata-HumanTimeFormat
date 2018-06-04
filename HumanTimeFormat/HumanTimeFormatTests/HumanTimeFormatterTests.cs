using Microsoft.VisualStudio.TestTools.UnitTesting;
using HumanTimeFormat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanTimeFormat.Tests
{
    [TestClass()]
    public class HumanTimeFormatterTests
    {
        [TestMethod()]
        public void TestInput0()
        {
            HumanTimeFormatter formatter = new HumanTimeFormatter();

            string expected = "now";

            string actual = formatter.Format( 0 );

            Assert.AreEqual( expected , actual );
        }
    }
}