using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MusicHub
{
    public partial class DataGridView1 : Form
    {
        public DataGridView1()
        {
            InitializeComponent();
        }

        private void DataGridView1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDetailsDataSet3.UserInfo' table. You can move, or remove it, as needed.
            this.userInfoTableAdapter.Fill(this.userDetailsDataSet3.UserInfo);

        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Final_System\UserDetails.mdf;Integrated Security=True;Connect Timeout=30");
        private object dataGridView1;

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from UserInfo", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void btnView_Click(object sender, EventArgs e)
        {
            
        }
    }
}
