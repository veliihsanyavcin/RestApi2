using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestApi2
{
    public class Recipe
    {
        public int id { get; set; }
        public double Period { get; } //Çıkış yapan araçların otopark ücretlendirmesi yapılırken kullanılan veri tipi.

        public double Cost { get; } //Otoprakımızdan çıkış yapan araçların ödedeği ücretlerin toplamın hesaplanması için kullandığımız veri tipi.

        public Recipe()
        {

        }
        public Recipe(double period, double cost)
        {
            
            this.Cost = cost;
            this.Period = period;
        }
    }
}
