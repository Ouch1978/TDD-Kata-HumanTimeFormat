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

        [TestMethod()]
        public void TestInput30()
        {
            _formatter.Format( 30 ).Should().Be( "30 seconds" );
        }

        [TestMethod()]
        public void TestInput60()
        {
            _formatter.Format( 60 ).Should().Be( "1 minute" );
        }

        [TestMethod()]
        public void TestInput61()
        {
            _formatter.Format( 61 ).Should().Be( "1 minute and 1 second" );
        }

        [TestMethod()]
        public void TestInput310()
        {
            _formatter.Format( 310 ).Should().Be( "5 minutes and 10 seconds" );
        }

        [TestMethod()]
        public void TestInput3600()
        {
            _formatter.Format( 3600 ).Should().Be( "1 hour" );
        }

        [TestMethod()]
        public void TestInput3661()
        {
            _formatter.Format( 3661 ).Should().Be( "1 hour, 1 minute and 1 second" );
        }

        [TestMethod()]
        public void TestInput3662()
        {
            _formatter.Format( 3662 ).Should().Be( "1 hour, 1 minute and 2 seconds" );
        }


        [TestMethod()]
        public void TestInput90061()
        {
            _formatter.Format( 90061 ).Should().Be( "1 day, 1 hour, 1 minute and 1 second" );
        }

        [TestMethod()]
        public void TestInput900610()
        {
            _formatter.Format( 900610 ).Should().Be( "10 days, 10 hours, 10 minutes and 10 seconds" );
        }

        [TestMethod()]
        public void TestInput31556926()
        {
            _formatter.Format( 31556926 ).Should().Be( "1 year" );
        }

        [TestMethod()]
        public void TestInput315569261()
        {
            _formatter.Format( 315569261 ).Should().Be( "10 years and 1 second" );
        }

        [TestMethod()]
        public void TestInput316469870()
        {
            _formatter.Format( 316469870 ).Should().Be( "10 years, 10 days, 10 hours, 10 minutes and 10 seconds" );
        }

    }
}