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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ContinueButton.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void DirectoryButton_Click(object sender, EventArgs e)
        {
            DialogResult result = Directory.ShowDialog();
            if (result == DialogResult.OK) SetupDirectory.Text = Directory.SelectedPath;
            ContinueButton.Enabled = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Acception fm = new Acception();
            fm.Show();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            f1.Owner = this;
            f1.Show();
            this.Hide();
        }
    }
}
