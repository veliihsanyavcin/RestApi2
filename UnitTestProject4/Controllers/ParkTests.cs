using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestApi2.Controllers;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace UnitTestProject4.Tests
{
    [TestClass()]
    public class ParkTests
    {
        [TestMethod()]
        public void GetTest()
        {
            RestApi2.Program.Main();

            ParkController park;


            var list = park.Get();

            Assert.Fail("Hata ");
        }

        [TestMethod()]
        public void PostTest()
        {
            Assert.Fail();
        }
    }
}