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
    public partial class AllProduct : Form
    {
        //private Main Menu;
        public AllProduct(Main Menu)
        {
            InitializeComponent();
            Console.WriteLine("Test");
            this.flowLayoutPanel1.Controls.Add(new Data("Merah", "150.000", Menu));
            this.flowLayoutPanel1.Controls.Add(new Data("Biru", "300.000", Menu));
            this.flowLayoutPanel1.Controls.Add(new Data("Kuning", "1.000.000", Menu));
            this.flowLayoutPanel1.Controls.Add(new Data("Hijau", "250.000", Menu));
            this.flowLayoutPanel1.Controls.Add(new Data("Putih", "50.000", Menu));
        }
    }
}
