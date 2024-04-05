using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace BillingApp
{
    public partial class Sale_Invoice : Form
    {

        SqlConnection COM = new SqlConnection("Data Source=DESKTOP-VL3BH6H;Initial Catalog=DB_BillingApp;Integrated Security=true;");
        public Sale_Invoice()
        {
            InitializeComponent();
        }

      

        private void ClientInvoice_Load(object sender, EventArgs e)
        {
            try
            {
                MTex_Total.Hide();
                loadProducts();
                InvoiceNo();
                DATALOAD();



                MTex_InvoiceDate.Text = DateTime.Now.ToString("dd MM yyyy");

              //  metroTextBox1.Text = Client_Details.clientid;
              //  metroTextBox2.Text = Client_Details.Email;
              //  metroTextBox3.Text = Client_Details.Contact;
              //  richTextBox2.Text = Client_Details.Address;
            } 
            catch(Exception ex)
            {

            }
            finally
            {
                
            }
        }

        public void DATALOAD()
        {
            try
            {
                metroTextBox3.Text = FrmDashBoard.Contact;
                metroTextBox1.Text = FrmDashBoard.Client_ID1;
                metroTextBox2.Text = FrmDashBoard.Email;
                richTextBox2.Text = FrmDashBoard.Address;

            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }
        public void InvoiceNo()

        {

            try
            {

                COM.Open();
                SqlCommand cmd = new SqlCommand("SP_InvoiceMaster", COM);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action","Invoicefetch");
                DataTable Dt = new DataTable();
                Dt.Load(cmd.ExecuteReader());
                COM.Close();

                int RowCount = Dt.Rows.Count;
                if (RowCount > 0)
                {
                    int s = Convert.ToInt32(Dt.Rows[0]["Invoice_No"]);
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
                COM.Close();
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            try
            {
                //string ProIndex = MCom_ProductName.SelectedIndex.ToString();
                //string ProName = MCom_ProductName.Text.ToString();
                int ProID =Convert.ToInt32(MCom_ProductName.SelectedValue.ToString());

                COM.Open();
                SqlCommand cmd = new SqlCommand("SP_Product_Details", COM);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action","ProPrice");
                cmd.Parameters.AddWithValue("@Product_ID",ProID);
                DataTable Dt = new DataTable();
                Dt.Load(cmd.ExecuteReader());
                COM.Close();


                if (Dt.Rows.Count>0)
                {
                    MTex_ProductID.Text =Convert.ToString( ProID);
                    MTex_Price.Text = Dt.Rows[0]["SellingPrice"].ToString();
                    MTex_AvailableStock.Text = Dt.Rows[0]["Stock"].ToString();
                }
                else
                {
                    MessageBox.Show("Price Invalid");
                }
            }

            //ProPrice(ProID);

            catch (Exception ex)
            {

            }
            finally
            {
                COM.Close();
            }

            //COM.Open();
            //SqlCommand cmd = new SqlCommand("SP_Product_Details", COM);
            //cmd.CommandType = CommandType.StoredProcedure;


            //COM.Close();
            // string ProIndex = MCom_ProductName.SelectedIndex.ToString();
            // string ProName = MCom_ProductName.Text.ToString();
            // string ProID = MCom_ProductName.SelectedValue.ToString();

            //  MessageBox.Show(ProIndex + "=" + ProName + "=" + ProID+ " Product Name");

            //MTex_ProductID.Text = ProID;

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
                cmd.Parameters.AddWithValue("@Stock", ProID);
                DataTable Dt = new DataTable();
                Dt.Load(cmd.ExecuteReader());
                COM.Close();

                MTex_Price.Text = Dt.Rows[0]["SellingPrice"].ToString();
                MTex_AvailableStock.Text = Dt.Rows[0]["Stock"].ToString();
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
                    metroGrid1.Rows.Add(MTex_ProductID.Text, MCom_ProductName.Text, MTex_Price.Text, MTex_Quantity.Text, MTex_Total.Text);

                }
                clear_Data();
                
                double  total=0;
                for (int i=0; i <= metroGrid1.Rows.Count -1; i++)
                {
                 
                    total =total+ Convert.ToDouble(metroGrid1.Rows[i].Cells[4].Value.ToString());
              

                }
                MTex_GrandTotal.Text = total.ToString();

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
                MTex_Quantity.Text = " ";
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                
            }


        }

        private void MTex_Total_Click(object sender, EventArgs e)
        {

        }

        private void MTex_GrandTotal_Click(object sender, EventArgs e)
        {
            try
            {
                COM.Open();
                SqlCommand cmd = new SqlCommand("SP_Product_Details", COM);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "Total");
                // cmd.Parameters.AddWithValue("@Product_ID", ProID);
                DataTable Dt = new DataTable();
                Dt.Load(cmd.ExecuteReader());
                COM.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                COM.Close();
            }
        }

        private void MTex_Total_Click_1(object sender, EventArgs e)
        {

        }

        private void MTex_InvoiceNo_Click(object sender, EventArgs e)
        {
           // MTex_InvoiceNo.Text = "100";
           // int S = Convert.ToInt32(MTex_InvoiceNo.Text);
           //
           // for(  int i=0;  i<S + 1; i++)
           // {
           //     MTex_InvoiceNo.Text = "100";
           // }
        }  //

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_GenerateInvoice_Click(object sender, EventArgs e)
        {
            InvoiceMaster();
            InvoiceDetais();
            printInvoice();
        }
        public void InvoiceMaster()
        {
           

                COM.Open();
                SqlCommand cmd = new SqlCommand("SP_InvoiceMaster", COM);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Action", "InsertInvoice");
             //   cmd.Parameters.AddWithValue("@Invoice_ID", MTex_ProductID.Text);
                cmd.Parameters.AddWithValue("@Invoice_No", MTex_InvoiceNo.Text);
                cmd.Parameters.AddWithValue("@Invoice_Date", MTex_InvoiceDate.Text);
                cmd.Parameters.AddWithValue("@Customer_ID", metroTextBox1.Text);
                cmd.Parameters.AddWithValue("@Grand_Total", MTex_GrandTotal.Text);
                cmd.ExecuteNonQuery();
                COM.Close();
            

            MessageBox.Show("Data Invoice Master Successfully", "Save");
        }
        public void printInvoice()
        {
            
            
                try
                {
                    ReportDocument rptdoc = new ReportDocument();
                    Report_Viewer crv = new Report_Viewer();
                    SqlCommand cmd = new SqlCommand("SP_InvoiceMaster", COM);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Action", "PrintInvoice"));
                    cmd.Parameters.Add(new SqlParameter("@Invoice_NO", MTex_InvoiceNo.Text));
                    COM.Open();
                    DataSet ds = new DataSet();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    COM.Close();
                    rptdoc.Load(Application.StartupPath + ("\\CR_Sale_Invoice.rpt"));
                //Passing Parameter to Report
                    TextObject Note = (TextObject)rptdoc.ReportDefinition.ReportObjects["Report_Note"];
                    Note.Text = Rtex_Message.Text;


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

        public void InvoiceDetais()
        {
            int Rowcount = metroGrid1.Rows.Count;
            //int MyRowIndex;
            COM.Open();

            for (int i = 0; i < Rowcount; i++)
            {
                SqlCommand cmd = new SqlCommand("SP_Invoice_Details", COM);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "InsertInvoice");
                cmd.Parameters.AddWithValue("@Invoice_No", MTex_InvoiceNo.Text);
                cmd.Parameters.AddWithValue("@Product_Price", metroGrid1.Rows[i].Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@Product_ID", metroGrid1.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@Prod_Quantity", metroGrid1.Rows[i].Cells[3].Value.ToString());
                cmd.Parameters.AddWithValue("@Total", metroGrid1.Rows[i].Cells[4].Value.ToString());
                cmd.ExecuteNonQuery();
            }
            COM.Close();
        }

      


    }
}


