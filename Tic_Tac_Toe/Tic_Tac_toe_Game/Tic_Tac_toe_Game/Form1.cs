using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boolean checker;
        int plusone;

       public void Enable_False()
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
        public void score()
        {

            if (btn_Tic1.Text == "X" && btn_Tic2.Text == "X" && btn_Tic3.Text == "X")
            {
                btn_Tic1.BackColor = Color.Red;
                btn_Tic2.BackColor = Color.Red;
                btn_Tic3.BackColor = Color.Red;

                MessageBox.Show("THe Winner is Player X", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl_PayerX.Text);
                lbl_PayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn_Tic1.Text == "X" && btn_Tic4.Text == "X" && btn_Tic7.Text == "X")
            {
                btn_Tic1.BackColor = Color.Pink;
                btn_Tic4.BackColor = Color.Pink;
                btn_Tic7.BackColor = Color.Pink;

                MessageBox.Show("THe Winner is Player X", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl_PayerX.Text);
                lbl_PayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            //                 3  Step
            if (btn_Tic1.Text == "X" && btn_Tic5.Text == "X" && btn_Tic9.Text == "X")
            {
                btn_Tic1.BackColor = Color.PowderBlue;
                btn_Tic5.BackColor = Color.PowderBlue;
                btn_Tic9.BackColor = Color.PowderBlue;

                MessageBox.Show("THe Winner is Player X", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl_PayerX.Text);
                lbl_PayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            //                4 Step
            if (btn_Tic3.Text == "X" && btn_Tic5.Text == "X" && btn_Tic7.Text == "X")
            {
                btn_Tic3.BackColor = Color.Crimson;
                btn_Tic5.BackColor = Color.Crimson;
                btn_Tic7.BackColor = Color.Crimson;

                MessageBox.Show("THe Winner is Player X", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl_PayerX.Text);
                lbl_PayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            //              5  _ Step
            if (btn_Tic2.Text == "X" && btn_Tic5.Text == "X" && btn_Tic8.Text == "X")
            {
                btn_Tic2.BackColor = Color.CadetBlue;
                btn_Tic5.BackColor = Color.CadetBlue;
                btn_Tic8.BackColor = Color.CadetBlue;

                MessageBox.Show("THe Winner is Player X", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl_PayerX.Text);
                lbl_PayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            //            6___Step
            if (btn_Tic3.Text == "X" && btn_Tic6.Text == "X" && btn_Tic9.Text == "X")
            {
                btn_Tic3.BackColor = Color.SlateBlue;
                btn_Tic6.BackColor = Color.SlateBlue;
                btn_Tic9.BackColor = Color.SlateBlue;

                MessageBox.Show("THe Winner is Player X", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl_PayerX.Text);
                lbl_PayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            //                7___Step
            if (btn_Tic7.Text == "X" && btn_Tic8.Text == "X" && btn_Tic9.Text == "X")
            {
                btn_Tic7.BackColor = Color.Yellow;
                btn_Tic8.BackColor = Color.Yellow;
                btn_Tic9.BackColor = Color.Yellow;

                MessageBox.Show("THe Winner is Player X", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl_PayerX.Text);
                lbl_PayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            //                8__Ste
            if (btn_Tic4.Text == "X" && btn_Tic5.Text == "X" && btn_Tic6.Text == "X")
            {
                btn_Tic4.BackColor = Color.Green;
                btn_Tic5.BackColor = Color.Green;
                btn_Tic6.BackColor = Color.Green;

                MessageBox.Show("THe Winner is Player X", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lbl_PayerX.Text);
                lbl_PayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            { 
               
                if (btn_Tic1.Text == "O" && btn_Tic2.Text == "O" && btn_Tic3.Text == "O")
                {
                    btn_Tic1.BackColor = System.Drawing.Color.Red;
                    btn_Tic2.BackColor = System.Drawing.Color.Red;
                    btn_Tic3.BackColor = System.Drawing.Color.Red;

                    MessageBox.Show("THe Winner is Player O", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    plusone = int.Parse(lbl_PlayerY.Text);
                    lbl_PlayerY.Text = Convert.ToString(plusone + 1);
                    Enable_False();
                }
                               
                if (btn_Tic1.Text == "O" && btn_Tic4.Text == "O" && btn_Tic7.Text == "O")
                {
                    btn_Tic1.BackColor = System.Drawing.Color.Pink;
                    btn_Tic4.BackColor = System.Drawing.Color.Pink;
                    btn_Tic7.BackColor = System.Drawing.Color.Pink;

                    MessageBox.Show("THe Winner is Player O", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    plusone = int.Parse(lbl_PlayerY.Text);
                    lbl_PlayerY.Text = Convert.ToString(plusone + 1);
                    Enable_False();
                }
                //                 3  Step
                if (btn_Tic1.Text == "O" && btn_Tic5.Text == "O" && btn_Tic9.Text == "O")
                {
                    btn_Tic1.BackColor = System.Drawing.Color.PowderBlue;
                    btn_Tic5.BackColor = System.Drawing.Color.PowderBlue;
                    btn_Tic9.BackColor = System.Drawing.Color.PowderBlue;

                    MessageBox.Show("The Winner is Player O", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    plusone = int.Parse(lbl_PlayerY.Text);
                    lbl_PlayerY.Text = Convert.ToString(plusone + 1);
                    Enable_False();
                }
                //                4 Step
                if (btn_Tic3.Text == "O" && btn_Tic5.Text == "O" && btn_Tic7.Text == "O")
                {
                    btn_Tic3.BackColor = System.Drawing.Color.Crimson;
                    btn_Tic5.BackColor = System.Drawing.Color.Crimson;
                    btn_Tic7.BackColor = System.Drawing.Color.Crimson;

                    MessageBox.Show("THe Winner is Player O", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    plusone = int.Parse(lbl_PlayerY.Text);
                    lbl_PlayerY.Text = Convert.ToString(plusone + 1);
                    Enable_False();
                }
                //              5  _ Step
                if (btn_Tic2.Text == "O" && btn_Tic5.Text == "O" && btn_Tic8.Text == "O")
                {
                    btn_Tic2.BackColor = System.Drawing.Color.CadetBlue;
                    btn_Tic5.BackColor = System.Drawing.Color.CadetBlue;
                    btn_Tic8.BackColor = System.Drawing.Color.CadetBlue;

                    MessageBox.Show("THe Winner is Player O", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    plusone = int.Parse(lbl_PlayerY.Text);
                    lbl_PlayerY.Text = Convert.ToString(plusone + 1);
                    Enable_False();
                }
                //            6___Step
                if (btn_Tic3.Text == "O" && btn_Tic6.Text == "O" && btn_Tic9.Text == "O")
                {
                    btn_Tic3.BackColor = System.Drawing.Color.SlateBlue;
                    btn_Tic6.BackColor = System.Drawing.Color.SlateBlue;
                    btn_Tic9.BackColor = System.Drawing.Color.SlateBlue;

                    MessageBox.Show("THe Winner is Player O", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    plusone = int.Parse(lbl_PlayerY.Text);
                    lbl_PlayerY.Text = Convert.ToString(plusone + 1);
                    Enable_False();
                }
                //                7___Step
                if (btn_Tic7.Text == "O" && btn_Tic8.Text == "O" && btn_Tic9.Text == "O")
                {
                    btn_Tic7.BackColor = System.Drawing.Color.Yellow;
                    btn_Tic8.BackColor = System.Drawing.Color.Yellow;
                    btn_Tic9.BackColor = System.Drawing.Color.Yellow;

                    MessageBox.Show("THe Winner is Player O", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    plusone = int.Parse(lbl_PlayerY.Text);
                    lbl_PlayerY.Text = Convert.ToString(plusone + 1);
                    Enable_False();
                }
                //                8__Step
                if (btn_Tic4.Text == "O" && btn_Tic5.Text == "O" && btn_Tic6.Text == "O")
                {
                    btn_Tic4.BackColor = System.Drawing.Color.Green;
                    btn_Tic5.BackColor = System.Drawing.Color.Green;
                    btn_Tic6.BackColor = System.Drawing.Color.Green;

                    MessageBox.Show("THe Winner is Player O", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    plusone = int.Parse(lbl_PlayerY.Text);
                    lbl_PlayerY.Text = Convert.ToString(plusone + 1);
                    Enable_False();
                }
            }
            
        }

        private void btn_Tic1_Click(object sender, EventArgs e)
        {
            if(checker == false)
            {
                btn_Tic1.Text = "X";
                checker = true;
            }
            else
            {
                btn_Tic1.Text = "O";
                checker = false;
            }
            score();
            btn_Tic1.Enabled = false;
        }

        private void btn_Tic2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn_Tic2.Text = "X";
                checker = true;
            }
            else
            {
                btn_Tic2.Text = "O";
                checker = false;
            }
            score();
            btn_Tic2.Enabled = false;
        }

        private void btn_Tic3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn_Tic3.Text = "X";
                checker = true;
            }
            else
            {
                btn_Tic3.Text = "O";
                checker = false;
            }
            score();
            btn_Tic3.Enabled = false;
        }

        private void btn_Tic4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn_Tic4.Text = "X";
                checker = true;
            }
            else
            {
                btn_Tic4.Text = "O";
                checker = false;
            }
            score();
            btn_Tic4.Enabled = false;
        }

        private void btn_Tic5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn_Tic5.Text = "X";
                checker = true;
            }
            else
            {
                btn_Tic5.Text = "O";
                checker = false;
            }
            score();
            btn_Tic5.Enabled = false;
        }

        private void btn_Tic6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn_Tic6.Text = "X";
                checker = true;
            }
            else
            {
                btn_Tic6.Text = "O";
                checker = false;
            }
            score();
            btn_Tic6.Enabled = false;
        }

        private void btn_Tic7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn_Tic7.Text = "X";
                checker = true;
            }
            else
            {
                btn_Tic7.Text = "O";
                checker = false;
            }
            score();
            btn_Tic7.Enabled = false;
        }

        private void btn_Tic8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn_Tic8.Text = "X";
                checker = true;
            }
            else
            {
                btn_Tic8.Text = "O";
                checker = false;
            }
            score();
            btn_Tic8.Enabled = false;
        }

        private void btn_Tic9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn_Tic9.Text = "X";
                checker = true;
            }
            else
            {
                btn_Tic9.Text = "O";
                checker = false;
            }
            score();
            btn_Tic9.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_newGame_Click(object sender, EventArgs e)
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

            lbl_PayerX.Text = "0";
            lbl_PlayerY.Text = "0";


            btn_Tic1.BackColor = Color.WhiteSmoke;
            btn_Tic2.BackColor = Color.WhiteSmoke;
            btn_Tic3.BackColor = Color.WhiteSmoke;
            btn_Tic4.BackColor = Color.WhiteSmoke;
            btn_Tic5.BackColor = Color.WhiteSmoke;
            btn_Tic6.BackColor = Color.WhiteSmoke;
            btn_Tic7.BackColor = Color.WhiteSmoke;
            btn_Tic8.BackColor = Color.WhiteSmoke;
            btn_Tic9.BackColor = Color.WhiteSmoke;


        }

        private void btn_Reset_Click(object sender, EventArgs e)
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


            btn_newGame.Enabled = true;

            btn_Tic1.BackColor = Color.WhiteSmoke;
            btn_Tic2.BackColor = Color.WhiteSmoke;
            btn_Tic3.BackColor = Color.WhiteSmoke;
            btn_Tic4.BackColor = Color.WhiteSmoke;
            btn_Tic5.BackColor = Color.WhiteSmoke;
            btn_Tic6.BackColor = Color.WhiteSmoke;
            btn_Tic7.BackColor = Color.WhiteSmoke;
            btn_Tic8.BackColor = Color.WhiteSmoke;
            btn_Tic9.BackColor = Color.WhiteSmoke;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm If You Want Exit", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (iExit == DialogResult.OK)
                {
                    Application.Exit();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
