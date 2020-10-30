using RestApi2.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;




namespace RestApi2
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string plate { get; set; }

        public string type { get; set; }
        public virtual Ticket Ticket { get; set; }
        


        public void CheckPlate() //Girilen plaka için kontrol yaptığımız metod.
        {
            //if (!textBox.MaskFull)
            //{

            //    throw new SyntaxErrorException();
            //}

            //string sehirKodu = textBox.Text.Substring(0, 2);

            //if (Convert.ToByte(sehirKodu) > 81 || Convert.ToByte(sehirKodu) < 1)
            //{

            //    throw new SyntaxErrorException();
            //}
            
        }
       
    }
    
}
