using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestApi2;
using RestApi2.Controllers;
using RestApi2.Data;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        private RestApiContext _restApiContext;

        [TestMethod]
        public void TestMethod1()
        {
            ParkController _pcontroller = new ParkController(_restApiContext);

            Ticket ticket = new Ticket();
            ticket.Id = 2;
            var t = _pcontroller.Post(ticket);


            LoginController _lcontroller = new LoginController();
            RestApi2.Login login = new RestApi2.Login();
            login.id = 1;
            login.password = "1";
            login.username = "1";
            var a = _lcontroller.Post(login);

            var b = a;
        }
    }
}
