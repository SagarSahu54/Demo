using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Configuration;
using CrystalDecisions.CrystalReports.Engine;

namespace BillingApp
{
    public partial class Client_Details : Form
    {


         //SqlConnection COM = new SqlConnection("Data Source=DESKTOP-VL3BH6H;Initial Catalog=DB_BillingApp;Integrated Security=true;");
       SqlConnection COM = new SqlConnection(ConfigurationManager.ConnectionStrings["Db_Connection"].ToString());

        public Client_Details()
        {
            InitializeComponent();
        }

        private void Client_DetailsSP()
        {
          
           
                COM.Open();
                 SqlCommand cmd = new SqlCommand("SP_Client_Details", COM);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.AddWithValue("@Action","SelectAll");
                /**SqlCommand cmd = new SqlCommand("Select * From Client_Details", COM);*/
                DataTable Dt = new DataTable();
                Dt.Load(cmd.ExecuteReader());
                COM.Close();
                dataGridView1.DataSource = Dt;

           

        }
        private void Client_Details_Load(object sender, EventArgs e)
        {
            Client_DetailsSP();
            text_Date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Text_Time.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_Submit.Text == "Submit")
                {
                    int Result = 0;
                     COM.Open();
                     SqlCommand cmd = new SqlCommand("SP_Client_Details",COM);
                     cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action","Insert");
                    cmd.Parameters.AddWithValue("@Client_Name",text_Name.Text);
                    cmd.Parameters.AddWithValue("@Email", text_Email.Text);
                    cmd.Parameters.AddWithValue("@Contact", text_Contact.Text);
                    cmd.Parameters.AddWithValue("@Address", text_Address.Text);
                    Result=cmd.ExecuteNonQuery();
                    COM.Close();
                    ClienDetails();

                    if (Result == 1)
                    {
                        MessageBox.Show("Clients Details Successfully", "Invoice");
                    }

                 //   MessageBox.Show("Data Insert Successfully");
                }

                if (btn_Submit.Text == "Update")
                {
                     COM.Open();
                     SqlCommand cmd = new SqlCommand("SP_Client_Details",COM);
                      cmd.CommandType = CommandType.StoredProcedure;
                      cmd.Parameters.AddWithValue("@Action","Update");
                      cmd.Parameters.AddWithValue("@Client_ID",text_ID.Text);
                      cmd.Parameters.AddWithValue("@Client_Name", text_Name.Text);
                      cmd.Parameters.AddWithValue("@Email", text_Email.Text);
                      cmd.Parameters.AddWithValue("@Contact", text_Contact.Text);
                      cmd.Parameters.AddWithValue("@Address", text_Address.Text);
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
        public void clear()
        {
            try
            {
                text_ID.Text = " ";
                text_Email.Text = " ";
                text_Address.Text = " ";
                text_Contact.Text = " ";
                text_Name.Text = " ";
            }
            catch(Exception ex)
            {

            }
            finally
            {
                COM.Close();
            }
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            
        }
        private void ClienDetails()
        {
            COM.Open();
            SqlCommand cmd = new SqlCommand("SP_Client_Details", COM);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action", "SelectAll");
            DataTable Dt = new DataTable();
            Dt.Load(cmd.ExecuteReader());
            COM.Close();
            dataGridView1.DataSource = Dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // btn_Submit.Text = Convert.ToString("Update");

            text_ID.Visible = true;
            text_ID.Text=dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            text_Name.Text=dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            text_Contact.Text=dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            text_Email.Text=dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            text_Address.Text=dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            btn_Submit.Text="Update";
            btn_Delete.Visible = true;   
          //  update();
        }
        int MyRowIndex;
        private void update()
        {

          
            dataGridView1.Rows[MyRowIndex].Cells[0].Value = text_ID.Text;
            dataGridView1.Rows[MyRowIndex].Cells[1].Value = text_Name.Text;
            dataGridView1.Rows[MyRowIndex].Cells[2].Value = text_Contact.Text;
            dataGridView1.Rows[MyRowIndex].Cells[3].Value = text_Email.Text;
            dataGridView1.Rows[MyRowIndex].Cells[4].Value = text_Address.Text;


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
            
        {
           //btn_Submit.Text = Convert.ToString("Update");
         
            text_ID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            text_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            text_Contact.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            text_Email.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            text_Address.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
           btn_Submit.Text = "Update";
            btn_Delete.Visible = true;
            text_ID.Visible = true;
          // update();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            COM.Open();
            SqlCommand cmd = new SqlCommand("SP_Client_Details", COM);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action","Delete");
            cmd.Parameters.Add(new SqlParameter("@Client_ID", text_ID.Text));
            cmd.ExecuteNonQuery();
            COM.Close();


            MessageBox.Show("Data Delete Successfully");
        }
        public static string Email;
        public static string  clientid;
        public static string Contact;
        public static string Address;
        private void btn_Cust_Invoice_Click(object sender, EventArgs e)
        {
             Email = text_Email.Text;
             clientid = text_ID.Text;
            Contact = text_Contact.Text;
            Address = text_Address.Text;

            Sale_Invoice Client = new Sale_Invoice();
            Client.ShowDialog();

        }

        

        private void btn_Refresh_Click_1(object sender, EventArgs e)
        {
          //  ClienDetails();
        }



        private void Tex_Search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter=String.Format("Client_Name LIKE '%{0}%'", Tex_Search.Text);
        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
        string File;
        private void btn_Excel_Click(object sender, EventArgs e)
        {
            
            saveFileDialog1.DefaultExt = ".xls";
            DialogResult DR = saveFileDialog1.ShowDialog();
            if (DR == DialogResult.OK)
            {
                File = saveFileDialog1.FileName;
               
            }
            else

            {

            }

            ExportExcel();
        }
        private void ExportExcel()
        {
            try
            {
                //DataTable DT = (DataTable)(dataGridView_Report.DataSource);
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("No Data Found.!", "Alert.!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                //int i = 0;
                //int j = 0;


                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {

                    xlWorkSheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;

                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {

                        xlWorkSheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();

                    }

                }

                xlWorkBook.SaveAs(@""+File, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                MessageBox.Show("Excel Created Successfully.!", "Alert.!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong.!", "Alert.!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {

            }
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void tex_clientPrint_Click(object sender, EventArgs e)
        {
            PrintClient();
        }
        public void PrintClient()
        {

            try
            {
                ReportDocument rptdoc = new ReportDocument();
                Report_Viewer crv = new Report_Viewer();
                SqlCommand cmd = new SqlCommand("SP_Client_Details", COM);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Action", "PrintClientDetails"));
                cmd.Parameters.Add(new SqlParameter("@Client_ID", text_ID.Text));
                COM.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                COM.Close();
                rptdoc.Load(Application.StartupPath + ("\\CR_ClientDetails.rpt"));
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
    }

}
