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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Licension.ScrollBars = ScrollBars.Vertical;
            ContinueButton.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Acception f = new Acception();
            f.Show();
        }

        private void AcceptRButton_CheckedChanged(object sender, EventArgs e)
        {
            ContinueButton.Enabled = true;
        }

        private void UnacceptRButton_CheckedChanged(object sender, EventArgs e)
        {
            ContinueButton.Enabled = false;
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Owner = this;
            f1.Show();
            this.Hide();
        }
    }
}
