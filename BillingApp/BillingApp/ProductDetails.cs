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
using CrystalDecisions.CrystalReports.Engine;


namespace BillingApp
{
    public partial class ProductDetails : Form
    {
        SqlConnection COM = new SqlConnection("Data Source=DESKTOP-VL3BH6H;Initial Catalog=DB_BillingApp;Integrated Security=true;");
        public ProductDetails()
        {
            InitializeComponent();
        }
        private void SP_ProductData()
        {
            COM.Open();
            SqlCommand cmd = new SqlCommand("SP_Product_Details", COM);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action","SelectAll");
            DataTable Dt = new DataTable();
            Dt.Load(cmd.ExecuteReader());
            COM.Close();
            dataGridView1.DataSource = Dt;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            FrmDashBoard MDash= new FrmDashBoard ();
            MDash.Show();
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            SP_ProductData();
        }
        int MyRowIndex;

        private void update()
        {

            dataGridView1.Rows[MyRowIndex].Cells[0].Value = text_ID.Text;
            dataGridView1.Rows[MyRowIndex].Cells[1].Value = text_Name.Text;
            dataGridView1.Rows[MyRowIndex].Cells[2].Value = text_MRP.Text;
            dataGridView1.Rows[MyRowIndex].Cells[3].Value = text_Selling.Text;
            dataGridView1.Rows[MyRowIndex].Cells[4].Value = text_Quantity.Text;

           
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void text_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            if (btn_Submit.Text == "Submit")
            {
                COM.Open();
                SqlCommand cmd = new SqlCommand("SP_Product_Details",COM);
                cmd.CommandType=CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Action","Insert");
                cmd.Parameters.AddWithValue("@Product_ID", text_ID.Text);
                cmd.Parameters.AddWithValue("@Product_Name", text_Name.Text);
                cmd.Parameters.AddWithValue("@MRP", Convert.ToInt32(text_MRP.Text));
                cmd.Parameters.AddWithValue("@SellingPrice", Convert.ToInt32(text_Selling.Text));
                cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(text_Quantity.Text));
                cmd.ExecuteNonQuery();
                COM.Close();

                MessageBox.Show("Data Insert Successfully");
            }
            Refresh();



            if (btn_Submit.Text == "Update")
            { 
                COM.Open();
                SqlCommand cmd = new SqlCommand("SP_Product_Details",COM);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action","Update");
                cmd.Parameters.AddWithValue("@Product_ID", text_ID.Text);
                cmd.Parameters.AddWithValue("@Product_Name", text_Name.Text);
                cmd.Parameters.AddWithValue("@MRP",Convert.ToInt32( text_MRP.Text));
                cmd.Parameters.AddWithValue("@SellingPrice",Convert.ToInt32( text_Selling.Text));
                cmd.Parameters.AddWithValue("@Stock",Convert.ToInt32( text_Quantity.Text));
                cmd.ExecuteNonQuery();
                COM.Close();
                ProductDetailsRefressh();
                MessageBox.Show("Data Update Successfully");
            }
            clear();
            btn_Submit.Text = "Submit";
        }
        public void clear()
        {
            try
            {
                text_ID.Text = " ";
                text_MRP.Text = " ";
                text_Name.Text = " ";
                text_Quantity.Text = " ";
                text_Selling.Text = " ";
            }
            catch(Exception ex)
            {

            }
            finally
            {
                COM.Close();
            }
        }
       
        
        public void Refresh()
        {
            COM.Open();
            SqlCommand cmd = new SqlCommand("SP_Product_Details", COM);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action", "SelectAll");
            DataTable Dt = new DataTable();
            Dt.Load(cmd.ExecuteReader());
            COM.Close();
            dataGridView1.DataSource = Dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Submit.Text = Convert.ToString("Update");
            text_ID.Visible = true;
            text_ID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            text_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            text_MRP.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            text_Selling.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            text_Quantity.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            btn_Submit.Text = "Update";
            btn_Delete.Visible = true;
            update();
        }
        private void ProductDetailsRefressh()
        {
            COM.Open();
            SqlCommand cmd = new SqlCommand("SP_Product_Details", COM);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action","SelectAll");
            DataTable Dt = new DataTable();
            Dt.Load(cmd.ExecuteReader());
            COM.Close();
            dataGridView1.DataSource = Dt;
        }

        private void btn_Dashboard_Click_1(object sender, EventArgs e)
        {
            FrmDashBoard Fdash = new FrmDashBoard();
            Fdash.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            COM.Open();
            SqlCommand cmd = new SqlCommand("SP_Product_Details", COM);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action", "Delete");
            DataTable Dt = new DataTable();
            Dt.Load(cmd.ExecuteReader());
            COM.Close();
            dataGridView1.DataSource = Dt;
        }

        private void MBtn_Stock_Click(object sender, EventArgs e)
        {
            PrintStock();
        }
        public void PrintStock()
        {
            try
            {
                ReportDocument rptdoc = new ReportDocument();
                Report_Viewer crv = new Report_Viewer();
                SqlCommand cmd = new SqlCommand("SP_Product_Details", COM);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Action", "SelectForStock"));
                
                // cmd.Parameters.Add(new SqlParameter("@SellingPrice", text_ID.Text));
                //   cmd.Parameters.Add(new SqlParameter("@Stock", text_ID.Text));

                COM.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                //DataTable Dt = new DataTable();
                //Dt.Load(cmd.ExecuteReader());
                //
                //dataGridView1.DataSource = Dt;
                COM.Close();
                rptdoc.Load(Application.StartupPath + ("\\CR_Stock.rpt"));
                //Passing Parameter to Report
                //TextObject Note = (TextObject)rptdoc.ReportDefinition.ReportObjects["Report_Note"];
                // Note.Text = Rtex_Message.Text;

                rptdoc.SetDataSource(ds.Tables[0]);


                crv.crystalReportViewer1.ReportSource = rptdoc;
                crv.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                COM.Close();
            }
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

