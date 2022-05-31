using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MusicPlayer2
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        public void Open()
        {
            ShowDialog();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            LoginForm LoginForm = new LoginForm();
            Thread MyThread = new Thread(LoginForm.Open);
            MyThread.Start();
            this.Dispose();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void RegistrateBtn_Click(object sender, EventArgs e)
        {
            RegistrationController registrationController = new RegistrationController(this);
            if (PasswordConfirmText.Text == PasswordText.Text)
            {
                registrationController.Registrate();
            }
            else
            {
                MessageBox.Show("Пароли не совпадают.");
            }
        }
    }
}
