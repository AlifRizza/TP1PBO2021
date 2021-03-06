using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Login : Form
    {
        readonly string Username = "alifrizza";
        readonly string Password = "pbo123";
        public Main MainMenu = new Main();
        public Login()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text == Username && TxtPassword.Text == Password)
            {
                MessageBox.Show("Kamu berhasil login");
                this.Hide();
                MainMenu.ShowDialog();
            }
            else if (TxtUsername.Text == "" || TxtPassword.Text == "")
            {
                MessageBox.Show("Kamu belum mengisi form login");
            }
            else
            {
                MessageBox.Show("Username atau Password Salah ");
            }
        }
    }
}
