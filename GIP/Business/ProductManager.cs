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
        


        //Producten toevoegen
        public String addProduct(String naam, String omschrijving, double prijs)
        {
            try
            {
                //Bestand ophalen
                var JsonData = System.IO.File.ReadAllText(@"C:\Users\user\AppData\Roaming\NetPay\Products.json");

                //Bestand uitlezen en omzetten naar lijst
                var productsLijst = JsonConvert.DeserializeObject<List<Product>>(JsonData)
                      ?? new List<Product>();

                if((productsLijst.FindIndex(Product => Product.Naam == naam)) < 0)
                {
                    //Nieuw product opbouwen
                    Product product = new Product(naam, omschrijving, prijs);

                    //Data toevoegen aan lijst
                    productsLijst.Add(product);


                    //Lijst converteren en weer toevoegen aan bestand
                    JsonData = JsonConvert.SerializeObject(productsLijst);
                    System.IO.File.WriteAllText(@"C:\Users\user\AppData\Roaming\NetPay\Products.json", JsonData);

                    return "success";
                }
                else
                {
                    return "excists";
                }



            }catch(Exception e)
            {
                return e.ToString();
            }
        }


        //Producten Verwijderen
        public String delProduct(String naam)
        {
            try
            {
                //Bestand ophalen
                var JsonData = System.IO.File.ReadAllText(@"C:\Users\user\AppData\Roaming\NetPay\Products.json");

                //Bestand uitlezen en omzetten naar lijst
                var productsLijst = JsonConvert.DeserializeObject<List<Product>>(JsonData)
                      ?? new List<Product>();

                var product = productsLijst.Single(Product => Product.Naam == naam);
                //Product verwijderen
                productsLijst.Remove(product);

                //Lijst converteren en weer toevoegen aan bestand
                JsonData = JsonConvert.SerializeObject(productsLijst);
                System.IO.File.WriteAllText(@"C:\Users\user\AppData\Roaming\NetPay\Products.json", JsonData);

                return "success";

            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
        

        //Producten uitlezen
        public List<Product> getAllProducts()
        {
            //Bestand ophalen
            var JsonData = System.IO.File.ReadAllText(@"C:\Users\user\AppData\Roaming\NetPay\Products.json");

            //Bestand uitlezen en omzetten naar lijst
            var productsLijst = JsonConvert.DeserializeObject<List<Product>>(JsonData);
            return productsLijst;
        }


    }


}

        









