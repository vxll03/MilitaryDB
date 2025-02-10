using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Military
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void Connect_Click(object sender, EventArgs e)
        {
            conn = new System.Data.SqlClient.SqlConnection("Server=" + DbServerName.Text + ";Database=" + DbName.Text + ";uid=" + userName.Text + ";pwd=" + userPassword.Text + ";encrypt=false" + "");
            Login loginForm = new Login();
            MainBtnForm mainForm = new MainBtnForm();

            try
            {
                conn.Open();
                MessageBox.Show("Подключено!");
                Program.Data.value = "Server=" + DbServerName.Text + ";Database=" + DbName.Text + ";uid=" + userName.Text + ";pwd=" + userPassword.Text + ";encrypt=false" + "";
                mainForm.Show();
                this.Hide();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
