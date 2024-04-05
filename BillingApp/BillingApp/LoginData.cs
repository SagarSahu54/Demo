using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingApp
{
    public partial class login : Form
    {


        SqlConnection COM = new SqlConnection("Data Source=DESKTOP-VL3BH6H;Initial Catalog=DB_BillingApp;Integrated Security=true;");
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

            loginload();
        }

        public void loginload()
        {


            try
            {
                COM.Open();
                SqlCommand cmd = new SqlCommand("SP_Login_details", COM);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action","SelectAll");
                /**SqlCommand cmd = new SqlCommand("Select * From Client_Details", COM);*/
                DataTable Dt = new DataTable();
                Dt.Load(cmd.ExecuteReader());
                COM.Close();
                metroGrid1.DataSource = Dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Data Error", "Error");
            }
            finally
            {
                COM.Close();
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tex_User_ID.Visible = true;
            tex_User_ID.Text =  metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tex_Username.Text = metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tex_Email.Text = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tex_Password.Text = metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
            metroButton1.Text = "Update";
            btn_Delete.Visible = true;
        }
        int MyRowIndex;
        private void update()
        {
            try
            {
                metroGrid1.Rows[MyRowIndex].Cells[0].Value = tex_User_ID.Text;
                metroGrid1.Rows[MyRowIndex].Cells[1].Value = tex_Username.Text;
                metroGrid1.Rows[MyRowIndex].Cells[2].Value = tex_Email.Text;
                metroGrid1.Rows[MyRowIndex].Cells[3].Value = tex_Password.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Update Erroe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                COM.Close();
            }
        }
        private void Mlab_Login_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroButton1.Text == "Submit")
                {
                    int Result = 0;
                    COM.Open();
                    SqlCommand cmd = new SqlCommand("SP_Login_details", COM);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "Insert");
                    cmd.Parameters.AddWithValue("@User_Name", tex_Username.Text);
                    cmd.Parameters.AddWithValue("@Email", tex_Email.Text);
                    cmd.Parameters.AddWithValue("Pass", tex_Password.Text);

                    Result = cmd.ExecuteNonQuery();
                    COM.Close();
                    loginDetails();

                    if (Result == 1)
                    {
                        MessageBox.Show("Clients Details Successfully", "Invoice");
                    }

                    //   MessageBox.Show("Data Insert Successfully");
                }

                if (metroButton1.Text == "Update")
                {
                    COM.Open();
                    SqlCommand cmd = new SqlCommand("SP_Login_details", COM);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "Update");
                    cmd.Parameters.AddWithValue("@UserID", tex_User_ID.Text);
                    cmd.Parameters.AddWithValue("@User_Name", tex_Username.Text);
                    cmd.Parameters.AddWithValue("@Email", tex_Email.Text);
                    cmd.Parameters.AddWithValue("@Pass", tex_Password.Text);
                    cmd.ExecuteNonQuery();
                    COM.Close();

                    MessageBox.Show("Data Update Successfully");
                    //  update();
                }
                clear();
                metroButton1.Text = "Submit";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Event Wrong", "Error");
            }
            finally
            {

                COM.Close();
            }
        }
        private void loginDetails()
        {

        }

        public void clear()
        {
            try
            {
                tex_User_ID.Text = " ";
                tex_Email.Text = " ";
                tex_Password.Text = " ";
                tex_Username.Text = " ";
            }
            catch (Exception ex)
            {

            }
            finally
            {
                COM.Close();
            }
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tex_User_ID.Visible = true;
            tex_User_ID.Text = metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tex_Username.Text = metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tex_Email.Text = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tex_Password.Text = metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
            metroButton1.Text = "Update";
            btn_Delete.Visible = true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
