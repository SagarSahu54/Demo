using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingApp
{
    public partial class SuppilerInvoice : Form
    {
        SqlConnection COM = new SqlConnection("Data Source=DESKTOP-VL3BH6H;Initial Catalog=DB_BillingApp;Integrated Security=true;");
        public SuppilerInvoice()
        {
            InitializeComponent();
        }

        private void SuppilerInvoice_Load(object sender, EventArgs e)
        {
            InvoiceNo();
            MTex_InvoiceDate.Text = DateTime.Now.ToString("dd MM yyyy");
            loadProducts();


            MTex_SupplierID.Text = SupplierDetails.Suppilerid;
            MTex_Email.Text = SupplierDetails.Email;
            MTex_Contact.Text = SupplierDetails.Contact;
            MTex_Address.Text = SupplierDetails.Address;
            MTex_Pancard.Text = SupplierDetails.Pancard;

        }
        public void InvoiceNo()
        {
            try
            {

                COM.Open();
                SqlCommand cmd = new SqlCommand("SP_PurchaseMaster", COM);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "Invoicefetch");
                DataTable Dt = new DataTable();
                Dt.Load(cmd.ExecuteReader());
              

                int RowCount = Dt.Rows.Count;
                if (RowCount > 0)
                {
                    int s = Convert.ToInt32(Dt.Rows[0]["PurchaseInvo_No"]);
                    MTex_InvoiceNo.Text = Convert.ToString(s + 1);
                }
                else
                {
                    MTex_InvoiceNo.Text = "100";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Some thing Event Wrong Invoice No ", "Error");
            }
            finally
            {
                COM.Close();
            }

        }


        private void loadProducts()
        {
            try
            {
                COM.Open();
                SqlCommand cmd = new SqlCommand("SP_Product_Details", COM);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "SelectAll");
                DataTable Dt = new DataTable();
                Dt.Load(cmd.ExecuteReader());
                COM.Close();
                MCom_ProductName.DataSource = Dt;
                MCom_ProductName.DisplayMember = "Product_Name";
                MCom_ProductName.ValueMember = "Product_ID";
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        private void MCom_ProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //string ProIndex = MCom_ProductName.SelectedIndex.ToString();
                //string ProName = MCom_ProductName.Text.ToString();
                string ProID = MCom_ProductName.SelectedValue.ToString();
                string MRP = MCom_ProductName.SelectedValue.ToString();


                COM.Open();
                SqlCommand cmd = new SqlCommand("SP_Product_Details", COM);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "ProPrice");
                cmd.Parameters.AddWithValue("@Product_ID", ProID);
                cmd.Parameters.AddWithValue("Stock", ProID);
                DataTable Dt = new DataTable();
                Dt.Load(cmd.ExecuteReader());

                // COM.Close();
                //MessageBox.Show(ProIndex + "=" + ProName + "=" + ProID + " Product Name");

                MTex_ProductID.Text = ProID;


                if (MTex_ProductID.Text == ProID)
                {
                    MTex_Price.Text = Dt.Rows[0]["SellingPrice"].ToString();
                    MTex_AvailableStock.Text = Dt.Rows[0]["Stock"].ToString();
                    MTex_MRP.Text= Dt.Rows[0]["MRP"].ToString();

                }
                else
                {
                    MessageBox.Show("Price Invalid");
                }
                } 
            catch (Exception ex)
            {

            }
            finally
            {
                COM.Close();
            }
        }
            public void ProPrice(String ProID)
            {

                try
                {
                    COM.Open();
                    SqlCommand cmd = new SqlCommand("SP_Product_Details", COM);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "ProPrice");
                    cmd.Parameters.AddWithValue("@Product_ID", ProID);
                    DataTable Dt = new DataTable();
                    Dt.Load(cmd.ExecuteReader());
                

                    MTex_Price.Text = Dt.Rows[0]["SellingPrice"].ToString();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    COM.Close();
                }


            }

        private void MBtn_AddItem_Click(object sender, EventArgs e)
        {

            try
            {



                MTex_Total.Text = ((Convert.ToInt32(MTex_Price.Text)) * (Convert.ToInt32(MTex_Quantity.Text))).ToString();
                {
                    metroGrid1.Rows.Add(MTex_ProductID.Text, MCom_ProductName.Text, MTex_Price.Text, MTex_MRP.Text, MTex_Quantity.Text, MTex_Total.Text);

                }
                clear_Data();

                double total = 0;
                for (int i = 0; i <= metroGrid1.Rows.Count - 1; i++)
                {

                    total = total + Convert.ToDouble(metroGrid1.Rows[i].Cells[5].Value.ToString());


                }
                MTex_GrandTotal.Text = total.ToString();
               // ProSub();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                COM.Close();
            }
        }
        public void clear_Data()
        {
            try
            {
                MTex_ProductID.Text = " ";
                //  MCom_ProductName;
                MTex_Price.Text = " ";
                MTex_MRP.Text = " ";
                MTex_Quantity.Text = " ";
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }

        }

        private void btn_GenerateInvoice_Click(object sender, EventArgs e)
        {
            PurchaseMaster();
            PurchaseDetails();
            ProSub();
        }
    
        public void PurchaseMaster()
        {

                COM.Open();
                SqlCommand cmd = new SqlCommand("SP_PurchaseMaster", COM);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Action", "InsertInvoice");
                cmd.Parameters.AddWithValue("@PurchaseInvo_No", MTex_InvoiceNo.Text);
                cmd.Parameters.AddWithValue("@Purchase_Date", MTex_InvoiceDate.Text);
                cmd.Parameters.AddWithValue("@Supplier_ID", MTex_SupplierID.Text);
                cmd.Parameters.AddWithValue("@Grand_Total", MTex_GrandTotal.Text);
                cmd.Parameters.AddWithValue("@Pancard", MTex_Pancard.Text);
                cmd.ExecuteNonQuery();
                COM.Close();
            

            MessageBox.Show("Data Master Successfully", "Save");
        }
        public void PurchaseDetails()
        {
            int Rowcount = metroGrid1.Rows.Count;

            COM.Open();
            for (int i = 0; i < Rowcount; i++)
            {
                SqlCommand cmd = new SqlCommand("SP_Purchase_Detail", COM);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "InsertInvoice");
                cmd.Parameters.AddWithValue("@Pur_No", MTex_InvoiceNo.Text);
                cmd.Parameters.AddWithValue("@Pro_ID", metroGrid1.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@Pro_MRP", metroGrid1.Rows[i].Cells[3].Value.ToString());
                cmd.Parameters.AddWithValue("@Pro_Price", metroGrid1.Rows[i].Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@Pro_Quantity", metroGrid1.Rows[i].Cells[4].Value.ToString());
                cmd.Parameters.AddWithValue("@Total", metroGrid1.Rows[i].Cells[5].Value.ToString());
                cmd.Parameters.AddWithValue("@Date", MTex_InvoiceDate.Text);
                cmd.ExecuteNonQuery();
            }
            COM.Close();

        }
        public void ProSub()
        {
            COM.Open();
            SqlCommand cmd = new SqlCommand("SP_Product_Details", COM);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action", "ProUpdate");
            cmd.Parameters.AddWithValue("@Product_ID", MTex_ProductID.Text);
            cmd.Parameters.AddWithValue("@Quantity", MTex_Quantity.Text);
            DataTable Dt = new DataTable();
            Dt.Load(cmd.ExecuteReader());
            COM.Close();
        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }
    }
}
