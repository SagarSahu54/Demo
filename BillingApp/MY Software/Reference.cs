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
    public partial class Reference : Form
    {
        public Reference()
        {
            InitializeComponent();
        }

        private void Reference_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Convert.ToString(MessageBox.Show("Save","Reference"));
        }

        private void tn_Cancel_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
