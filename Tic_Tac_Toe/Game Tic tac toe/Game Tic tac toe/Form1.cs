using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Tic_tac_toe
{
    public partial class Form1 : Form
    {

        Boolean Checker;

        public void EnabledFalse()
        {
            btn_Tic1.Enabled = false;
            btn_Tic2.Enabled = false;
            btn_Tic3.Enabled = false;
            btn_Tic4.Enabled = false;
            btn_Tic5.Enabled = false;
            btn_Tic6.Enabled = false;
            btn_Tic7.Enabled = false;
            btn_Tic8.Enabled = false;
            btn_Tic9.Enabled = false;

        }
        public void Score()
        {     //   1 step
            if (btn_Tic1.Text == "X" && btn_Tic2.Text == "X" && btn_Tic3.Text == "X")
            {
                MessageBox.Show("You are Win the Game", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // 2 step
            if (btn_Tic2.Text == "X" && btn_Tic5.Text == "X" && btn_Tic8.Text == "X")
            {
                MessageBox.Show("You are Win the Game", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // 3 step
            if (btn_Tic4.Text == "X" && btn_Tic5.Text == "X" && btn_Tic6.Text == "X")
            {
                MessageBox.Show("You are Win the Game", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // 4 step
            if (btn_Tic3.Text == "X" && btn_Tic6.Text == "X" && btn_Tic9.Text == "X")
            {
                MessageBox.Show("You are Win the Game", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // 5 step
            if (btn_Tic7.Text == "X" && btn_Tic8.Text == "X" && btn_Tic9.Text == "X")
            {
                MessageBox.Show("You are Win the Game", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // 6 step
            if (btn_Tic1.Text == "X" && btn_Tic5.Text == "X" && btn_Tic9.Text == "X")
            {
                MessageBox.Show("You are Win the Game", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // 7 step
            if (btn_Tic3.Text == "X" && btn_Tic5.Text == "X" && btn_Tic7.Text == "X")
            {
                MessageBox.Show("You are Win the Game", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // 8 step
            if (btn_Tic1.Text == "X" && btn_Tic4.Text == "X" && btn_Tic7.Text == "X")
            {
                MessageBox.Show("You are Win the Game", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            //============================================== O ==============================================
            if (btn_Tic1.Text == "O" && btn_Tic2.Text == "O" && btn_Tic3.Text == "O")
            {
                MessageBox.Show("You are Win the Game", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // 2 step
            if (btn_Tic2.Text == "O" && btn_Tic5.Text == "O" && btn_Tic8.Text == "O")
            {
                MessageBox.Show("You are Win the Game", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // 3 step
            if (btn_Tic4.Text == "O" && btn_Tic5.Text == "O" && btn_Tic6.Text == "O")
            {
                MessageBox.Show("You are Win the Game", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // 4 step
            if (btn_Tic3.Text == "O" && btn_Tic6.Text == "O" && btn_Tic9.Text == "O")
            {
                MessageBox.Show("You are Win the Game", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // 5 step
            if (btn_Tic7.Text == "O" && btn_Tic8.Text == "O" && btn_Tic9.Text == "O")
            {
                MessageBox.Show("You are Win the Game", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // 6 step
            if (btn_Tic1.Text == "O" && btn_Tic5.Text == "O" && btn_Tic9.Text == "O")
            {
                MessageBox.Show("You are Win the Game", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // 7 step
            if (btn_Tic3.Text == "O" && btn_Tic5.Text == "O" && btn_Tic7.Text == "O")
            {
                MessageBox.Show("You are Win the Game", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // 8 step
            if (btn_Tic1.Text == "O" && btn_Tic4.Text == "O" && btn_Tic7.Text == "O")
            {
                MessageBox.Show("You are Win the Game ", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Tic1_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                btn_Tic1.Text = "X";
                Checker = true;
            }
            else
            {
                btn_Tic1.Text = "O";
                Checker = false;
            }
            Score();
            btn_Tic1.Enabled = false;

        }

        private void btn_Tic2_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                btn_Tic2.Text = "X";
                Checker = true;
            }
            else
            {
                btn_Tic2.Text = "O";
                Checker = false;
            }
            Score();
            btn_Tic2.Enabled = false;
        }

        private void btn_Tic3_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                btn_Tic3.Text = "X";
                Checker = true;
            }
            else
            {
                btn_Tic3.Text = "O";
                Checker = false;
            }
            Score();
            btn_Tic3.Enabled = false;
        }

        private void btn_Tic4_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                btn_Tic4.Text = "X";
                Checker = true;
            }
            else
            {
                btn_Tic4.Text = "O";
                Checker = false;
            }
            Score();
            btn_Tic4.Enabled = false;
        }

        private void btn_Tic5_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                btn_Tic5.Text = "X";
                Checker = true;
            }
            else
            {
                btn_Tic5.Text = "O";
                Checker = false;
            }
            Score();
            btn_Tic5.Enabled = false;
        }

        private void btn_Tic6_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                btn_Tic6.Text = "X";
                Checker = true;
            }
            else
            {
                btn_Tic6.Text = "O";
                Checker = false;
            }
            Score();
            btn_Tic6.Enabled = false;
        }

        private void btn_Tic7_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                btn_Tic7.Text = "X";
                Checker = true;
            }
            else
            {
                btn_Tic7.Text = "O";
                Checker = false;
            }
            Score();
            btn_Tic7.Enabled = false;
        }
        private void btn_Tic8_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                btn_Tic8.Text = "X";
                Checker = true;
            }
            else
            {
                btn_Tic8.Text = "O";
                Checker = false;
            }
            Score();
            btn_Tic8.Enabled = false;
        }

        private void btn_Tic9_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                btn_Tic9.Text = "X";
                Checker = true;
            }
            else
            {
                btn_Tic9.Text = "O";
                Checker = false;
            }
            Score();
            btn_Tic9.Enabled = false;
        }

        private void btn_Game_Click(object sender, EventArgs e)
        {
            btn_Tic1.Enabled = true;
            btn_Tic2.Enabled = true;
            btn_Tic3.Enabled = true;
            btn_Tic4.Enabled = true;
            btn_Tic5.Enabled = true;
            btn_Tic6.Enabled = true;
            btn_Tic7.Enabled = true;
            btn_Tic8.Enabled = true;
            btn_Tic9.Enabled = true;

            btn_Tic1.Text = "";
            btn_Tic2.Text = "";
            btn_Tic3.Text = "";
            btn_Tic4.Text = "";
            btn_Tic5.Text = "";
            btn_Tic6.Text = "";
            btn_Tic7.Text = "";
            btn_Tic8.Text = "";
            btn_Tic9.Text = "";

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
