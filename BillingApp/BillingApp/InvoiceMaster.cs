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
    public partial class InvoiceMaster : Form
    {
        SqlConnection COM = new SqlConnection("Data Source=DESKTOP-VL3BH6H;Initial Catalog=DB_BillingApp;Integrated Security=true;");
        public InvoiceMaster()
        {
            InitializeComponent();
        }

        private void Mlab_InvoiceMaster_Click(object sender, EventArgs e)
        {

        }

        private void InvoiceMaster_Load(object sender, EventArgs e)
        {
            InnvoiceForm();
    }
        public void InnvoiceForm()
        {
            COM.Open();
            SqlCommand cmd = new SqlCommand("SP_InvoiceMaster", COM);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action", "SelctAll");
            // cmd.Parameters.AddWithValue("@Product_ID", ProID);
            cmd.Parameters.AddWithValue("@Invoice_ID","Invoice_ID");
            DataTable Dt = new DataTable();
            Dt.Load(cmd.ExecuteReader());
            COM.Close();
            metroGrid1.DataSource = Dt;

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
