using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer2
{
    public class User
    {
        int userID;
        string login;
        string password;
        string firstName;
        string secondName;

        public void SetUserID(int userID)
        {
            this.userID = userID;
        }

        public int GetUserID()
        {
            return userID;
        }

        public void SetLogin(string login)
        {
            this.login = login;
        }

        public string GetLogin()
        {
            return login;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public void SetSecondName(string secondName)
        {
            this.secondName = secondName;
        }

        public string GetSecondName()
        {
            return secondName;
        }
    }
}
