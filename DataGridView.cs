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
    public partial class DataGridView : Form
    {
        private int rowIndex = 0;
        public DataGridView()
        {
            InitializeComponent();
        }

        private void DataGridView_Load(object sender, EventArgs e)
        {
            
            //BindData();
            // TODO: This line of code loads data into the 'userDetailsDataSet.UserInfo' table. You can move, or remove it, as needed.
            this.userInfoTableAdapter.Fill(this.userDetailsDataSet.UserInfo);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Final_System\UserDetails.mdf;Integrated Security=True;Connect Timeout=30");

        public object DataAccess { get; private set; }

        private void btnView_Click(object sender, EventArgs e)
        {
            BindData();
        }

        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from UserInfo", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //BindData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Final_System\UserDetails.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update UserInfo set FName = @FName, LName = @LName, Contact = @Contact, Address = @Address, UName = @UName, Password = @Password, CPassword = @CPassword", con);
            cmd.Parameters.AddWithValue("@FName", FName);
            cmd.Parameters.AddWithValue("@LName", LName);
            cmd.Parameters.AddWithValue("@Contact", Contact);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@UName", UName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@CPassword", CPassword);

            con.Close();
            MessageBox.Show("Successfully Updated!");
            */

        }

        private void btnView_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        
        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView1_ColumnContextMenuStripChanged(object sender, DataGridViewColumnEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            Registration r = new Registration();
            r.Show();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }
    }
}
