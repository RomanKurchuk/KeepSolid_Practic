using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPN_Unlimited_Setup
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void SetupButton_Click(object sender, EventArgs e)
        {
            Form5 f1 = new Form5();
            f1.Owner = this;
            f1.Show();
            this.Hide();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Acception fm = new Acception();
            fm.Show();
        }
    }
}
