using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Gebruiker
    {
        /*public String Gebruikersnaam { get; set; }
         public String Voornaam { get; set; }
         public  String Achternaam { get; set; }
         public  double Saldo { get; set; }*/
        private int userID; 

        public int UserID
        {
            get { return userID; }
        }

        public Gebruiker(int id)
        {
            /*Gebruikersnaam = gebruikersnaam;
            Voornaam = voornaam;
            Achternaam = achternaam;
            Saldo = saldo;*/
            this.userID = id;
        }


    }

    public static class GlobalInfo
    {
        private static Gebruiker gebruiker;

        public static Gebruiker Gebruiker {
            get { return gebruiker; }
            set { gebruiker = value; }

        }

    }


}
