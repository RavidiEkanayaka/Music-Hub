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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Final_System\UserDetails.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Final_System\UserDetails.mdf;Integrated Security=True;Connect Timeout=30");

            string FName = txtFName.Text;
            string LName = txtLName.Text;
            string Contact = txtContact.Text;
            string Address = txtAddress.Text;
            string UName = txtUName.Text;
            string Password = txtPassword.Text;
            string ConfirmPassword = txtCPassword.Text;

            string qry = "Insert Into UserInfo values('" + FName + "','" + LName + "','" + Contact + "','" + Address + "','" + UName + "','" + Password + "','" + ConfirmPassword + "')";

            SqlCommand cmd1 = new SqlCommand(qry, con);

            //Insert
            try
            {
                con.Open();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                this.Hide();
                Home h = new Home();
                h.Show();
            }
            finally
            {
                con.Close();
            }
            */

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Final_System\UserDetails.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into UserInfo values (@FName,@LName,@Contact,@Address,@UName,@Password,@CPassword)", con);
            cmd.Parameters.AddWithValue("@FName",txtFName.Text);
            cmd.Parameters.AddWithValue("@LName", txtLName.Text);
            cmd.Parameters.AddWithValue("@Contact", int.Parse(txtContact.Text));
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@UName", txtUName.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@CPassword", txtCPassword.Text);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Successfully Inserted!");

            
        }
        /*
        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from UserInfo", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            dataGridView1.DataSource = dt;
        }
        */
        private void btnView_Click(object sender, EventArgs e)
        {
            //BindData();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDetailsDataSet1.UserInfo' table. You can move, or remove it, as needed.
            //this.userInfoTableAdapter.Fill(this.userDetailsDataSet1.UserInfo);
            //BindData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            con.Open();
            SqlCommand command = new SqlCommand("update UserInfo set Fname '"+txtFName.Text+"', LName = '"+txtLName.Text+"',Contact = '"+txtContact.Text+"',Address = '"+txtAddress.Text+"',UName = '"+txtUName.Text+"',Password = '"+txtPassword.Text+"',CPassword = '"+txtCPassword.Text+"' ", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated!");
            BindData();
            */
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DataGridView dgv = new DataGridView();
            dgv.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Final_System\UserDetails.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update UserInfo set FName = @FName, LName = @LName, Contact = @Contact, Address = @Address, UName = @UName, Password = @Password, CPassword = @CPassword", con);
            
            cmd.Parameters.AddWithValue("@FName", txtFName.Text);
            cmd.Parameters.AddWithValue("@LName", txtLName.Text);
            cmd.Parameters.AddWithValue("@Contact", int.Parse(txtContact.Text));
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@UName", txtUName.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@CPassword", txtCPassword.Text);

            con.Close();
            MessageBox.Show("Successfully Updated!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Final_System\UserDetails.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete UserInfo where Contact = @Contact",con);
            cmd.Parameters.AddWithValue("@Contact", int.Parse(txtContact.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted!");

        }
    }
}
