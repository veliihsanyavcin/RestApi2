using System;
using System.ComponentModel.DataAnnotations;

namespace RestApi2
{
    public class Login
    {
        
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }

    }
}
