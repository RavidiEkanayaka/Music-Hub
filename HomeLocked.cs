using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicHub
{
    public partial class HomeLocked : Form
    {
        public HomeLocked()
        {
            InitializeComponent();
        }

        private void morebtn_Click(object sender, EventArgs e)
        {
            Registration registrationform = new Registration();
            registrationform.Show();
            this.Hide();
        }
    }
}
