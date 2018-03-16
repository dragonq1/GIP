using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CryptSharp;

namespace Business
{

    public class Comm
    {
        //Vars
        public String strConString = "server=185.114.157.174;user id=dragv_GIP;persistsecurityinfo=True;database=dragv_GIP;password=3gVtD0Id2";
     

        public String Login(String gebruikersnaam, String wachtwoord)
        {
            //Vars
            String result = "false";
            MySqlConnection conn = new MySqlConnection(strConString);
            MySqlCommand cmd = new MySqlCommand("SELECT Gebruikersnaam, Voornaam, Achternaam, Saldo, idGebruiker, Wachtwoord FROM Gebruikers WHERE Gebruikersnaam = @Gebruikersnaam;", conn);
            cmd.Parameters.AddWithValue("Gebruikersnaam", gebruikersnaam);

            try
            {
                conn.Open();

                MySqlDataReader datareader = cmd.ExecuteReader();


                while (datareader.Read())
                {
                    if (!(datareader.IsDBNull(0)))
                    {
                        String strGN = datareader["Gebruikersnaam"].ToString();
                        String strVoornaam = datareader["Voornaam"].ToString();
                        String strAchternaam = datareader["Achternaam"].ToString();
                        double dblSaldo = double.Parse(datareader["Saldo"].ToString());
                        int intID = Convert.ToInt16(datareader["idGebruiker"]);
                        String strHash = datareader["Wachtwoord"].ToString();
                        GlobalInfo.Gebruiker = new Gebruiker(intID);                     


                        bool verify = Crypter.CheckPassword(wachtwoord, strHash);

                        if(verify)
                        {
                            result = "true";
                        }
                        else
                        {
                            result = "false";
                        }
                    }
                    else
                    {
                        result = "false";
                    }
                }
                conn.Close();
            }
            catch (Exception e)
            {
                result = e.ToString();
            }
            return result;
        }

        public Boolean ResetUser()
        {
            Boolean result = false;
            try
            {

                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public String addBetaling(String qrCode, double dblBedrag)
        {
            Gebruiker gebruiker = GlobalInfo.Gebruiker;

            String result = "success";
            MySqlConnection conn = new MySqlConnection(strConString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Transacties (idCode, idOntvanger, Bedrag, Datum, Uitgevoerd) VALUES (@idCode, @idOntvanger, @Bedrag, now(), 0)", conn);
            cmd.Parameters.AddWithValue("idCode", qrCode);
            cmd.Parameters.AddWithValue("idOntvanger", gebruiker.UserID);
            cmd.Parameters.AddWithValue("Bedrag", dblBedrag);

            try
            {
                conn.Open();

                int resultconn = cmd.ExecuteNonQuery();

                if (!(resultconn == 0))
                {
                    result = "success";
                }
                else
                {
                    result = "false";
                }

            }
            catch (Exception e)
            {
                result = "ID" + gebruiker.UserID + "Fout: " + e.ToString();
            }



            return result;
        }

        //Betaling checken
        public Boolean checkBetaling(String qrCode)
        {
            //Vars
            Boolean result = false;

            MySqlConnection conn = new MySqlConnection(strConString);
            MySqlCommand cmd = new MySqlCommand("SELECT idCode FROM Transacties WHERE idCode = @idCode AND Uitgevoerd = 1;", conn);
            cmd.Parameters.AddWithValue("idCode", qrCode);

            try
            {
                conn.Open();

                MySqlDataReader datareader = cmd.ExecuteReader();


                while (datareader.Read())
                {
                    if (!(datareader.IsDBNull(0)))
                    {
                        String strQRCode = datareader["idCode"].ToString();
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
                conn.Close();
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }
    }
}
