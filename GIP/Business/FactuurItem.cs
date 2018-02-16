using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class FactuurItem
    {
        public String PNaam { get; set; }
        public double PrijsPS { get; set; }
        public int Aantal { get; set; }
        public double PrijsT { get; set; }

        public FactuurItem(String naam, double prijsps, int aantal, double prijst)
        {
            PNaam = naam;
            PrijsPS = prijsps;
            Aantal = aantal;
            PrijsT = prijst;
        }

        public FactuurItem()
        {

        }

        public void addOne()
        {
            Aantal++;
            PrijsT = Aantal * PrijsPS;
        }

        public void minOne()
        {
            Aantal--;
            PrijsT = Aantal * PrijsPS;
        }


    }
}
