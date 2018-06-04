using Microsoft.VisualStudio.TestTools.UnitTesting;
using HumanTimeFormat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace HumanTimeFormat.Tests
{
    [TestClass()]
    public class HumanTimeFormatterTests
    {
        HumanTimeFormatter _formatter = new HumanTimeFormatter();

        [TestMethod()]
        public void TestInput0()
        {
            _formatter.Format( 0 ).Should().Be( "now" );
        }

        [TestMethod()]
        public void TestInput1()
        {
            _formatter.Format( 1 ).Should().Be( "1 second" );
        }

    }
}