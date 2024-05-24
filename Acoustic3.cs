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
    public partial class Acoustic3 : Form
    {
        public Acoustic3()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Acoustic2 acousticform2 = new Acoustic2();
            acousticform2.Show();
            this.Hide();
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
            Acoustic4 acousticform4 = new Acoustic4();
            acousticform4.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AcousticBuy3 acousticBuy3 = new AcousticBuy3();
            acousticBuy3.Show();
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
