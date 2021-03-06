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
    public partial class DetailProduct : Form
    {
        public DetailProduct(string nama, string harga)
        {
            InitializeComponent();
            this.label1.Text = nama;
            this.label2.Text = harga;
        }
    }
}