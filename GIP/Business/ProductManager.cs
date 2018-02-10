using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace Business
{
    

    public class ProductManager
    {
        public String addProduct(String naam, String omschrijving, double prijs)
        {
            try
            {


                Product product = new Product
                {
                    Naam = naam,
                    Omschrijving = omschrijving,
                    Prijs = prijs
                };

                System.IO.File.WriteAllText(@"C:\Users\user\AppData\Roaming\Products.JSON", JsonConvert.SerializeObject(product));

                using (System.IO.StreamWriter file = System.IO.File.CreateText(@"C:\Users\user\AppData\Roaming\Products.JSON"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, product);
                }
                return "success";

            }catch(Exception e)
            {
                return e.ToString();
            }
        }
    }
}

        









