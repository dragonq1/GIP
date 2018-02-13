using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Product
    {
        public String Naam { get; set; }
        public String Omschrijving { get; set; }
        public double Prijs { get; set; }

        public Double getPrijs()
        {
            return Prijs;
        }

        public String getNaam()
        {
            return Naam;
        }

        public String getOmschrijving()
        {
            return Omschrijving;
        }
    }



}
