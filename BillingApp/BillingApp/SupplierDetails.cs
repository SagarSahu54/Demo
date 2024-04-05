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
    public partial class SupplierDetails : Form
    {

        SqlConnection COM = new SqlConnection("Data Source=DESKTOP-VL3BH6H;Initial Catalog=DB_BillingApp;Integrated Security=true;");
        public SupplierDetails()
        {
            InitializeComponent();
        }

        private void SupplierDetails_Load(object sender, EventArgs e)
        {
            Supplier_DetailsSP();
        }
        private void Supplier_DetailsSP()
        {

            try
            {
                COM.Open();
                SqlCommand cmd = new SqlCommand("SP_Supplier_Details", COM);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "SelectAll");
                /**SqlCommand cmd = new SqlCommand("Select * From Client_Details", COM);*/
                DataTable Dt = new DataTable();
                Dt.Load(cmd.ExecuteReader());
                COM.Close();
                dataGridView1.DataSource = Dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("wrong Event Suppiler Details", "Error");
            }
            finally
            {
                COM.Close();

            }



        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            try
            {
                if (btn_Submit.Text == "Submit")
                {
                    int Result = 0;
                    COM.Open();
                    SqlCommand cmd = new SqlCommand("SP_Supplier_Details", COM);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "Insert");
                    cmd.Parameters.AddWithValue("@Supplier_Name", text_Name.Text);
                    cmd.Parameters.AddWithValue("@Email", text_Email.Text);
                    cmd.Parameters.AddWithValue("@Contact", text_Contact.Text);
                    cmd.Parameters.AddWithValue("@Address", text_Address.Text);
                    cmd.Parameters.AddWithValue("@Pancard",tex_Pancard.Text);
                    Result = cmd.ExecuteNonQuery();
                    COM.Close();

                    if (Result == 1)
                    {
                        MessageBox.Show("Supplier Details Successfully", "Invoice");
                    }
                    SupplierDetails1();
                    //   MessageBox.Show("Data Insert Successfully");
                }

                if (btn_Submit.Text == "Update")
                {
                    COM.Open();
                    SqlCommand cmd = new SqlCommand("SP_Supplier_Details", COM);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "Update");
                    cmd.Parameters.AddWithValue("@Supplier_ID", text_ID.Text);
                    cmd.Parameters.AddWithValue("@Supplier_Name", text_Name.Text);
                    cmd.Parameters.AddWithValue("@Email", text_Email.Text);
                    cmd.Parameters.AddWithValue("@Contact", text_Contact.Text);
                    cmd.Parameters.AddWithValue("@Address", text_Address.Text);
                    cmd.Parameters.AddWithValue("@Pancard", tex_Pancard.Text);
                    cmd.ExecuteNonQuery();
                    COM.Close();

                    MessageBox.Show("Data Update Successfully");
                    //  update();
                }
                clear();
                btn_Submit.Text = "Submit";
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

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {

                COM.Open();
                SqlCommand cmd = new SqlCommand("SP_Supplier_Details", COM);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action","Delete");
                cmd.Parameters.Add(new SqlParameter("@Supplier_ID", text_ID.Text));
                cmd.ExecuteNonQuery();
                


                MessageBox.Show("Data Delete Successfully");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Sommething Event Wrong", "Error");
            }
            finally
            {
                COM.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                text_ID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                text_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                text_Contact.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                text_Email.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                text_Address.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                tex_Pancard.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                btn_Submit.Text = "Update";
                btn_Delete.Visible = true;
                text_ID.Visible = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Datagridview CellClick", "Error");
            }
            finally
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                text_ID.Visible = true;
                text_ID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                text_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                text_Contact.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                text_Email.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                text_Address.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                tex_Pancard.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                btn_Submit.Text = "Update";
                btn_Delete.Visible = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("CellContent", "Error");

            }
            finally
            {

            }
        }
        private void SupplierDetails1()
        {
            try
            {
                COM.Open();
                SqlCommand cmd = new SqlCommand("SP_Supplier_Details", COM);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "SelectAll");
                DataTable Dt = new DataTable();
                Dt.Load(cmd.ExecuteReader());
                COM.Close();
                dataGridView1.DataSource = Dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SupplieDetails", "Error");
            }
            finally
            {
                COM.Close();
            }
        }
        public void clear()
        {
            try
            {
                text_Address.Text = " ";
                text_Contact.Text = " ";
                text_ID.Text = " ";
                text_Name.Text = " ";
                tex_Pancard.Text = " ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("CLear Error", "Error");
            }
            finally
            {
                COM.Close();
            }
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
           // SupplierDetails1();
        }
        public static string  Email;
        public static string Suppilerid;
        public static string Contact;
        public static string Address;
        public static string Pancard;
        private void btn_Cust_Invoice_Click(object sender, EventArgs e)
        {
            Email = text_Email.Text;
            Suppilerid = text_ID.Text;
            Contact = text_Contact.Text;
            Address = text_Address.Text;
            Pancard = tex_Pancard.Text;

            SuppilerInvoice SuppInvo = new SuppilerInvoice();
            SuppInvo.Show();




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
