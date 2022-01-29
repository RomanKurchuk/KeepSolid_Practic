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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void CheckBoxFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (FolderName.Enabled == false) FolderName.Enabled = true;
            else FolderName.Enabled = false;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            Form4 f1 = new Form4();
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
