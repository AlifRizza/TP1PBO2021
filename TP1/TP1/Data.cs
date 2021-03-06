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
    public partial class Data : UserControl
    {
        private string nama;
        private string harga;
        private Main Menu;
        public Data(string nama, string harga, Main Menu)
        {
            InitializeComponent();
            this.label1.Text = nama;
            this.label2.Text = harga;
            this.nama = nama;
            this.harga = harga;
            this.Menu = Menu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetailProduct produk = new DetailProduct(nama, harga);
            this.Menu.OpenChildForm(produk);
            this.Menu.hideButton("Show");
        }
    }
}
