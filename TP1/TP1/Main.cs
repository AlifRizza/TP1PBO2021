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
    public partial class Main : Form
    {
        private Form activeForm;
        public Main()
        {
            InitializeComponent();
            OpenChildForm(new AllProduct(this));
        }

        
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(childForm);
            this.panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AllProduct(this));
            this.comboBox1.Visible = true;
            this.comboBox2.Visible = true;
            this.button4.Visible = true;
            this.button5.Visible = false;
        }

        public void hideButton(string text)
        {
            if (text == "Show")
            {
                this.comboBox1.Visible = false;
                this.comboBox2.Visible = false;
                this.button4.Visible = false;
                this.button5.Visible = true;
            } else
            {
                this.comboBox1.Visible = true;
                this.comboBox2.Visible = true;
                this.button4.Visible = true;
                this.button5.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://shopee.co.id/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Login log = new Login();
            log.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AllProduct(this));
            this.comboBox1.Visible = true;
            this.comboBox2.Visible = true;
            this.button4.Visible = true;
            this.button5.Visible = false;
        }
    }
}
