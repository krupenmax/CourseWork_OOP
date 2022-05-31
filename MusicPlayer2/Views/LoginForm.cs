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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public void Open()
        {
            ShowDialog();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            RegisterForm RegisterForm = new RegisterForm();
            Thread MyThread = new Thread(RegisterForm.Open);
            MyThread.Start();
            this.Dispose();
            this.Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginController loginController = new LoginController();
            if (loginController.CheckLogin(LoginText.Text, PasswordText.Text) == true)
            {
                MainForm MainForm = new MainForm(loginController);
                Thread MyThread = new Thread(MainForm.Open);
                MyThread.Start();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Логин или пароль введены неверно.");
            }
        }
    }
}
