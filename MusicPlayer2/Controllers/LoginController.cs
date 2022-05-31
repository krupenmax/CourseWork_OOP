using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MusicPlayer2
{
    public class LoginController
    {
        string login;
        public LoginController()
        {

        }

        public bool CheckLogin(string login, string password)
        {
            bool isFound = false;
            DataRow[] row = Program.dataController.GetDatabase().tableSet.Data.Tables["Users"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                if (Convert.ToString(row[i]["login"]) == login && Convert.ToString(row[i]["password"]) == password)
                {
                    isFound = true;
                    this.login = login;
                }
            }
            return isFound;
        }

        public string GetLogin()
        {
            return login;
        }
    }
}
