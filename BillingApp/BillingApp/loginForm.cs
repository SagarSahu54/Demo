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
    public partial class loginForm : Form
    {


        SqlConnection COM = new SqlConnection("Data Source=DESKTOP-VL3BH6H;Initial Catalog=DB_BillingApp;Integrated Security=true;");
        public loginForm()
        {
            InitializeComponent();
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void MBtn_login_Click(object sender, EventArgs e)
        {
            loginAction();
            //string S = "Billing Form Login Successfully ";
            //string tittle = "Display a Billing Form";
            //string incorrect = "Incorrect your are username and password ";
            //
            //
            //if (MTex_Username.Text == "Sagar.Pro" && MTex_Password.Text == "Sagar@1234")
            //{
            //    MessageBox.Show(S, tittle, MessageBoxButtons.YesNo);
            //}
            //else
            //{
            //    MessageBox.Show(incorrect, tittle);
            //}
            //
            //DialogResult option = new DialogResult();
            //option = MessageBox.Show(S, tittle, MessageBoxButtons.YesNo);
            //if (option == DialogResult.Yes)
            //{
            //    FrmDashBoard frmDash = new FrmDashBoard();
            //    frmDash.ShowDialog();
            //}
            //else
            //{
            //    this.Close();
            //}
        }   //
        public void loginAction()
        {
            try
            {
                COM.Open();
                SqlCommand cmd = new SqlCommand("SP_Login_details", COM);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "SelectAll");
                cmd.Parameters.AddWithValue("@User_Name", MTex_Username.Text);
                cmd.Parameters.AddWithValue("@Pass", MTex_Password.Text);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                COM.Close();
                int DTCount = dt.Rows.Count;
                if(DTCount > 0)
                {
                    int ID = Convert.ToInt32(dt.Rows[0]["User_ID"].ToString());
                    string Pass = dt.Rows[0]["Password"].ToString();
                    FrmDashBoard frm = new FrmDashBoard();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username not Found", "Warning!");
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

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
