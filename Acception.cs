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
    public partial class Acception : Form
    {
        public Acception()
        {
            InitializeComponent();
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
