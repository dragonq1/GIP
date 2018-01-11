using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Business
{
    public class Comm
    {
        //Vars
        public String[] userInfo = new String[4];
        public String strConString = "server=37.34.58.100;user id=dragv_GIP;persistsecurityinfo=True;database=dragv_GIP;password=Julia.2000";

        public String Login(String gebruikersnaam, String wachtwoord)
        {


            //Vars
            String result = "false";
            MySqlConnection conn = new MySqlConnection(strConString);
            MySqlCommand cmd = new MySqlCommand("SELECT Gebruikersnaam, Voornaam, Achternaam, Saldo FROM Gebruikers WHERE Gebruikersnaam = @Gebruikersnaam AND Wachtwoord = @Wachtwoord;", conn);
            cmd.Parameters.AddWithValue("@Gebruikersnaam", gebruikersnaam);
            cmd.Parameters.AddWithValue("@Wachtwoord", wachtwoord);

            try
            {
                conn.Open();

                MySqlDataReader datareader = cmd.ExecuteReader();

                while (datareader.Read())
                {
                    userInfo[0] = datareader["Gebruikersnaam"].ToString();
                    userInfo[1] = datareader["Voornaam"].ToString();
                    userInfo[2] = datareader["Achternaam"].ToString();
                    userInfo[3] = datareader["Saldo"].ToString();
                }

                conn.Close();
                result = "true";

            }
            catch(Exception e) {
                result = e.ToString();
            }
            return result;
        }
    }
}
