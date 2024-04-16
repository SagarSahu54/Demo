using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Configuration;
//using Microsoft.Office.Interop.Excel;
//using Microsoft.Office.Interop.Excel;

namespace BillingApp
{
    public partial class FrmDashBoard : Form
    {
        SqlConnection COM = new SqlConnection(ConfigurationManager.ConnectionStrings["Db_Connection"].ToString());
        public FrmDashBoard()
        {
            InitializeComponent();
        }

        private void Mtex_Time_Click(object sender, EventArgs e)
        {

        }

        private void FrmDashBoard_Load(object sender, EventArgs e)
        {


            int r, p;
            // r = Convert.ToInt32(16);
            // p =  int.Parse(Mtex_Time.Text);
            //  r = Convert.ToInt32( 0 < 18);
            //  Mtex_Time.Text = r.ToString();

            int time = Convert.ToInt32(DateTime.Now.ToString("HH"));
            Mtex_Time.Text = DateTime.Now.ToString("HH");
            Mtex_Date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            MTex_Time2.Text = DateTime.Now.ToString("hh:mm:ss");
    //        if (Mtex_Time.Text == DateTime.Now.ToString("HH"))
           // {
                if (time>0 && time<12)
                {
                    lab_Greeting.Text = "Good Morning \n -- Have A Nice Day--";
                }
                if (time>13 && time<16 )
                {

                    lab_Greeting.Text = "Good Afternoon \n -- Have A Nice Day---";
                }
               if (time>17 && time<19)
                {
                    lab_Greeting.Text = "Good Evening \n -- Have A Nice Day --";
                }
                 if (time>20 && time<24)
                {
                    lab_Greeting.Text = "Good Afternoon  \n -- Have A Nice Day--";
                }
          
        }

        public void LoginAction()
        {
            
                try
                {

                }
                catch (Exception ex)
                {

                }
                finally
                {

                 }
        }


        private void metroButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            loginForm LOG = new loginForm();
            LOG.ShowDialog();
        }

       
       

        

        private void MBtn_Clients_Click(object sender, EventArgs e)
        {
            Client_Details Cdet = new Client_Details();
            Cdet.ShowDialog();  
        }

        private void MBtn_Product_Click(object sender, EventArgs e)
        {
            ProductDetails Pdet = new ProductDetails();
            Pdet.ShowDialog();
        }

        private void MBtn_Stock_Click(object sender, EventArgs e)
        {
            Stock stk = new Stock();
            stk.ShowDialog();
        }



        private void metroButton3_Click(object sender, EventArgs e)
        {
            InvoiceMaster InvoM = new InvoiceMaster();
            InvoM.ShowDialog();
        }

       
        private void MBtn_Supplier_Click(object sender, EventArgs e)
        {
            SupplierDetails SupD = new SupplierDetails();
            SupD.ShowDialog();
        }

        private void btn_SetUserPass_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.ShowDialog();
        }

        private void btn_Calculato_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void btn_Notepad_Click(object sender, EventArgs e)
        {
            Process.Start("notepad");
        }

        private void btn_SearchInvoice_Click(object sender, EventArgs e)
        {
            Frm_SearchInvoice sear = new Frm_SearchInvoice();
            sear.ShowDialog();  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
               
            
            
        }
        public static string Contact,Client_Name,Client_ID1,Address,Email;
        private void btn_Submit_Click(object sender, EventArgs e)
        {
          
            COM.Open();
            SqlCommand cmd = new SqlCommand("SP_Client_Details", COM);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action", "ContactDetails");
            cmd.Parameters.AddWithValue("@Contact", textBox1.Text);
            DataTable Dt = new DataTable();
            Dt.Load(cmd.ExecuteReader());
            COM.Close();
            // Datadetail= Dt.ToString();
            int DTCount = Dt.Rows.Count;
            if (DTCount > 0)
            {    
                 Client_ID1 =Dt.Rows[0]["Client_ID"].ToString();
                Contact = Dt.Rows[0]["Contact"].ToString();
                 Address = Dt.Rows[0]["Address"].ToString();
                Email = Dt.Rows[0]["Email"].ToString();
                Sale_Invoice data = new Sale_Invoice();
                data.ShowDialog();
            }
            else
            {
                MessageBox.Show("Client Details not Found", "Warning!");
            }
           // Sale_Invoice data = new Sale_Invoice();
           // data.ShowDialog();
           // COM.Close();
            //  textBox1.Text = Sale_Invoice.Details;
        }
    }
      
}
