using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;

namespace Business
{
    class ProductManager
    {
        public void addProduct(String naam, String omschrijving, double prijs)
        {
            Product product = new Product
            {
                Naam = naam,
                Omschrijving = omschrijving,
                Prijs = prijs
            };

            

        }
    }
}

        









