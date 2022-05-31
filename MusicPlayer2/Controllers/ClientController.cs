using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MusicPlayer2
{
    public class ClientController
    {
        User CurrentUser;

        public void GetUserByLogin(string login)
        {
            User user = new User();
            DataRow[] row = Program.dataController.GetDatabase().tableSet.Data.Tables["Users"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                if (Convert.ToString(row[i]["login"]) == login)
                {
                    user.SetUserID(Convert.ToInt16(row[i]["userID"]));
                    user.SetLogin(Convert.ToString(row[i]["login"]));
                    user.SetPassword(Convert.ToString(row[i]["password"]));
                    user.SetFirstName(Convert.ToString(row[i]["firstName"]));
                    user.SetSecondName(Convert.ToString(row[i]["secondName"]));
                }
            }
            CurrentUser = user;
        }
    }
}
