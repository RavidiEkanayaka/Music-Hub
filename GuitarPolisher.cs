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
    public partial class GuitarPolisher : Form
    {
        public GuitarPolisher()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LockingTuner lockingTuner = new LockingTuner();
            lockingTuner.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Capo capo = new Capo();
            capo.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GuitarPolisherBuy guitarPolisherBuy = new GuitarPolisherBuy();
            guitarPolisherBuy.Show();
            this.Hide();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Home homeform = new Home();
            homeform.Show();
            this.Hide();
        }

        private void electricbtn_Click(object sender, EventArgs e)
        {
            Electric electricform = new Electric();
            electricform.Show();
            this.Hide();
        }

        private void acousticbtn_Click(object sender, EventArgs e)
        {
            Acoustic1 acousticform1 = new Acoustic1();
            acousticform1.Show();
            this.Hide();
        }

        private void accessoriesbtn_Click(object sender, EventArgs e)
        {
            Strings strings = new Strings();
            strings.Show();
            this.Hide();
        }

        private void contactbtn_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.Show();
            this.Hide();
        }
    }
}
