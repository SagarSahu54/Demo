using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_Software
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string S = "My Software Login Successfully";
            string tittle = "My Softwarre Window";
            string incorrect = "Incorrect your are username and password ";
            

            if (tex_Username.Text == "Sagar.Pro" && tex_Password.Text == "Sagar@1234" && tex_EmailID.Text == "SagarSahu43@gmail.com")
            {
               
                MessageBox.Show(S, tittle, MessageBoxButtons.YesNo);
                DashBoards das = new DashBoards();
                das.Show();
               
            }
            else
            {
                MessageBox.Show(incorrect, tittle);
            }
            //Btn_Login.Visible = true;
            /*DialogResult option = new DialogResult();
            option = MessageBox.Show(S, tittle, MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                frm_DashBoard frmDash = new frm_DashBoard();
                frmDash.ShowDialog();
            }
            else
            {
                this.Close();
            }*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
