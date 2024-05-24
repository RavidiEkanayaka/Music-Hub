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
    public partial class Acoustic4 : Form
    {
        public Acoustic4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Electric electricform = new Electric();
            electricform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home homeform = new Home();
            homeform.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Acoustic5 acousticform5 = new Acoustic5();
            acousticform5.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Acoustic3 acousticform3 = new Acoustic3();
            acousticform3.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AcousticBuy4 acousticBuy4 = new AcousticBuy4();
            acousticBuy4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Acoustic1 acousticform1 = new Acoustic1();
            acousticform1.Show();
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
