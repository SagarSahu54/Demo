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
    public partial class Stock : Form
    {
        SqlConnection COM = new SqlConnection("Data Source=DESKTOP-VL3BH6H;Initial Catalog=DB_BillingApp;Integrated Security=true;");
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            SP_ProductData();
        }
        private void SP_ProductData()
        {
            COM.Open();
            SqlCommand cmd = new SqlCommand("SP_Product_Details", COM);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action", "SelectForStock");
            /*  cmd.Parameters.AddWithValue("@Product_ID", text_ID.Text);
              cmd.Parameters.AddWithValue("@Product_Name", text_Name.Text);
              cmd.Parameters.AddWithValue("@MRP", text_MRP.Text);
              cmd.Parameters.AddWithValue("@SellingPrice", text_Selling.Text);
              cmd.Parameters.AddWithValue("@Quantity", text_Quantity.Text);*/
            DataTable Dt = new DataTable();
            Dt.Load(cmd.ExecuteReader());
            COM.Close();
            dataGridView1.DataSource = Dt;
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
                 // cmd.Parameters.Add(new SqlParameter("@Product_Id", text_ID.Text);
                // cmd.Parameters.Add(new SqlParameter("@SellingPrice", text_ID.Text));
                //   cmd.Parameters.Add(new SqlParameter("@Stock", text_ID.Text));

                COM.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable Dt = new DataTable();
                Dt.Load(cmd.ExecuteReader());
                
                dataGridView1.DataSource = Dt;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MBtn_StockPrint_Click(object sender, EventArgs e)
        {
            PrintStock();
        }
    }
}
