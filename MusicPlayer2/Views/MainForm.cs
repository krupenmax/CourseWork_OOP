using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer2
{
    public partial class MainForm : Form
    {
        ClientController clientController = new ClientController();
        public MainForm(LoginController loginController)
        {
            InitializeComponent();
            clientController.GetUserByLogin(loginController.GetLogin());
        }

        public void Open()
        {
            ShowDialog();
        }
    }
}
