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
    public partial class Electric4 : Form
    {
        public Electric4()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Electric3 electricform3 = new Electric3();
            electricform3.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Electric5 electricform5 = new Electric5();
            electricform5.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home homeform = new Home();
            homeform.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ElectricBuy4 electricBuy4 = new ElectricBuy4();
            electricBuy4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Acoustic1 acousticform1 = new Acoustic1();
            acousticform1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Electric electricform = new Electric();
            electricform.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Strings strings = new Strings();
            strings.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.Show();
            this.Hide();
        }
    }
}
