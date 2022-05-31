using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace MusicPlayer2
{
    public class RegistrationController
    {
        RegisterForm RegisterForm;
        public RegistrationController(RegisterForm RegisterForm)
        {
            this.RegisterForm = RegisterForm;
        }

        public void Registrate()
        {
            DataController dataController = Program.dataController;
            DataRow[] row = dataController.GetDatabase().tableSet.Data.Tables["Users"].Select();
            dataController.GetDatabase().tableSet.Data.Tables["Users"].Rows.Add(new object[] {row.Length + 1    , RegisterForm.LoginText.Text,
                RegisterForm.PasswordText.Text, RegisterForm.FirstNameText.Text, RegisterForm.SecondNameText.Text});

            string path = "../../Models/Docs/Users.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.Write("\n\"" + row.Length + 1 + "\"" + ",\"" + RegisterForm.LoginText.Text + "\"" + ",\""
                    + RegisterForm.PasswordText.Text + "\"" + ",\"" + RegisterForm.FirstNameText.Text + "\"" + ",\"" + RegisterForm.SecondNameText.Text 
                    + "\"");
            }
        }
    }
}
