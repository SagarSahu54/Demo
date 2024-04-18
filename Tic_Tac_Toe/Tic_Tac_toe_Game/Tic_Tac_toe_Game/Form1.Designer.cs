namespace Tic_Tac_toe_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_newGame = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_PlayerY = new System.Windows.Forms.Label();
            this.lbl_PayerX = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Tic9 = new System.Windows.Forms.Button();
            this.btn_Tic8 = new System.Windows.Forms.Button();
            this.btn_Tic7 = new System.Windows.Forms.Button();
            this.btn_Tic6 = new System.Windows.Forms.Button();
            this.btn_Tic5 = new System.Windows.Forms.Button();
            this.btn_Tic4 = new System.Windows.Forms.Button();
            this.btn_Tic3 = new System.Windows.Forms.Button();
            this.btn_Tic2 = new System.Windows.Forms.Button();
            this.btn_Tic1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(159, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 81);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "TiC TAC TOE Game";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(102, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 421);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_newGame);
            this.panel6.Controls.Add(this.btn_Exit);
            this.panel6.Controls.Add(this.btn_Reset);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(543, 218);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(408, 196);
            this.panel6.TabIndex = 2;
            // 
            // btn_newGame
            // 
            this.btn_newGame.BackColor = System.Drawing.Color.White;
            this.btn_newGame.Location = new System.Drawing.Point(7, 30);
            this.btn_newGame.Name = "btn_newGame";
            this.btn_newGame.Size = new System.Drawing.Size(388, 71);
            this.btn_newGame.TabIndex = 14;
            this.btn_newGame.Text = "New Game";
            this.btn_newGame.UseVisualStyleBackColor = false;
            this.btn_newGame.Click += new System.EventHandler(this.btn_newGame_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(204, 108);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(191, 71);
            this.btn_Exit.TabIndex = 13;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.White;
            this.btn_Reset.Location = new System.Drawing.Point(7, 107);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(191, 71);
            this.btn_Reset.TabIndex = 12;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbl_PlayerY);
            this.panel5.Controls.Add(this.lbl_PayerX);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(540, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(411, 196);
            this.panel5.TabIndex = 1;
            // 
            // lbl_PlayerY
            // 
            this.lbl_PlayerY.BackColor = System.Drawing.Color.White;
            this.lbl_PlayerY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_PlayerY.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayerY.Location = new System.Drawing.Point(214, 92);
            this.lbl_PlayerY.Name = "lbl_PlayerY";
            this.lbl_PlayerY.Size = new System.Drawing.Size(171, 39);
            this.lbl_PlayerY.TabIndex = 4;
            this.lbl_PlayerY.Text = "0";
            this.lbl_PlayerY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_PayerX
            // 
            this.lbl_PayerX.BackColor = System.Drawing.Color.White;
            this.lbl_PayerX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_PayerX.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PayerX.Location = new System.Drawing.Point(218, 30);
            this.lbl_PayerX.Name = "lbl_PayerX";
            this.lbl_PayerX.Size = new System.Drawing.Size(167, 39);
            this.lbl_PayerX.TabIndex = 3;
            this.lbl_PayerX.Text = "0";
            this.lbl_PayerX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Player O:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player X:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Tic9);
            this.panel3.Controls.Add(this.btn_Tic8);
            this.panel3.Controls.Add(this.btn_Tic7);
            this.panel3.Controls.Add(this.btn_Tic6);
            this.panel3.Controls.Add(this.btn_Tic5);
            this.panel3.Controls.Add(this.btn_Tic4);
            this.panel3.Controls.Add(this.btn_Tic3);
            this.panel3.Controls.Add(this.btn_Tic2);
            this.panel3.Controls.Add(this.btn_Tic1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(515, 380);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btn_Tic9
            // 
            this.btn_Tic9.BackColor = System.Drawing.Color.White;
            this.btn_Tic9.Location = new System.Drawing.Point(315, 250);
            this.btn_Tic9.Name = "btn_Tic9";
            this.btn_Tic9.Size = new System.Drawing.Size(139, 128);
            this.btn_Tic9.TabIndex = 11;
            this.btn_Tic9.UseVisualStyleBackColor = false;
            this.btn_Tic9.Click += new System.EventHandler(this.btn_Tic9_Click);
            // 
            // btn_Tic8
            // 
            this.btn_Tic8.BackColor = System.Drawing.Color.White;
            this.btn_Tic8.Location = new System.Drawing.Point(170, 253);
            this.btn_Tic8.Name = "btn_Tic8";
            this.btn_Tic8.Size = new System.Drawing.Size(139, 125);
            this.btn_Tic8.TabIndex = 10;
            this.btn_Tic8.UseVisualStyleBackColor = false;
            this.btn_Tic8.Click += new System.EventHandler(this.btn_Tic8_Click);
            // 
            // btn_Tic7
            // 
            this.btn_Tic7.BackColor = System.Drawing.Color.White;
            this.btn_Tic7.Location = new System.Drawing.Point(25, 257);
            this.btn_Tic7.Name = "btn_Tic7";
            this.btn_Tic7.Size = new System.Drawing.Size(139, 123);
            this.btn_Tic7.TabIndex = 9;
            this.btn_Tic7.UseVisualStyleBackColor = false;
            this.btn_Tic7.Click += new System.EventHandler(this.btn_Tic7_Click);
            // 
            // btn_Tic6
            // 
            this.btn_Tic6.BackColor = System.Drawing.Color.White;
            this.btn_Tic6.Location = new System.Drawing.Point(315, 126);
            this.btn_Tic6.Name = "btn_Tic6";
            this.btn_Tic6.Size = new System.Drawing.Size(139, 118);
            this.btn_Tic6.TabIndex = 8;
            this.btn_Tic6.UseVisualStyleBackColor = false;
            this.btn_Tic6.Click += new System.EventHandler(this.btn_Tic6_Click);
            // 
            // btn_Tic5
            // 
            this.btn_Tic5.BackColor = System.Drawing.Color.White;
            this.btn_Tic5.Location = new System.Drawing.Point(170, 126);
            this.btn_Tic5.Name = "btn_Tic5";
            this.btn_Tic5.Size = new System.Drawing.Size(139, 121);
            this.btn_Tic5.TabIndex = 7;
            this.btn_Tic5.UseVisualStyleBackColor = false;
            this.btn_Tic5.Click += new System.EventHandler(this.btn_Tic5_Click);
            // 
            // btn_Tic4
            // 
            this.btn_Tic4.BackColor = System.Drawing.Color.White;
            this.btn_Tic4.Location = new System.Drawing.Point(25, 126);
            this.btn_Tic4.Name = "btn_Tic4";
            this.btn_Tic4.Size = new System.Drawing.Size(139, 121);
            this.btn_Tic4.TabIndex = 6;
            this.btn_Tic4.UseVisualStyleBackColor = false;
            this.btn_Tic4.Click += new System.EventHandler(this.btn_Tic4_Click);
            // 
            // btn_Tic3
            // 
            this.btn_Tic3.BackColor = System.Drawing.Color.White;
            this.btn_Tic3.Location = new System.Drawing.Point(315, 12);
            this.btn_Tic3.Name = "btn_Tic3";
            this.btn_Tic3.Size = new System.Drawing.Size(139, 110);
            this.btn_Tic3.TabIndex = 5;
            this.btn_Tic3.UseVisualStyleBackColor = false;
            this.btn_Tic3.Click += new System.EventHandler(this.btn_Tic3_Click);
            // 
            // btn_Tic2
            // 
            this.btn_Tic2.BackColor = System.Drawing.Color.White;
            this.btn_Tic2.Location = new System.Drawing.Point(170, 14);
            this.btn_Tic2.Name = "btn_Tic2";
            this.btn_Tic2.Size = new System.Drawing.Size(139, 107);
            this.btn_Tic2.TabIndex = 4;
            this.btn_Tic2.UseVisualStyleBackColor = false;
            this.btn_Tic2.Click += new System.EventHandler(this.btn_Tic2_Click);
            // 
            // btn_Tic1
            // 
            this.btn_Tic1.BackColor = System.Drawing.Color.White;
            this.btn_Tic1.Location = new System.Drawing.Point(25, 12);
            this.btn_Tic1.Name = "btn_Tic1";
            this.btn_Tic1.Size = new System.Drawing.Size(139, 107);
            this.btn_Tic1.TabIndex = 3;
            this.btn_Tic1.UseVisualStyleBackColor = false;
            this.btn_Tic1.Click += new System.EventHandler(this.btn_Tic1_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(547, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 111);
            this.panel4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(439, 39);
            this.label4.TabIndex = 2;
            this.label4.Text = "Welcome In Sagar Gamer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1068, 618);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------------------------------------------";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Tic1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Tic9;
        private System.Windows.Forms.Button btn_Tic8;
        private System.Windows.Forms.Button btn_Tic7;
        private System.Windows.Forms.Button btn_Tic6;
        private System.Windows.Forms.Button btn_Tic5;
        private System.Windows.Forms.Button btn_Tic4;
        private System.Windows.Forms.Button btn_Tic3;
        private System.Windows.Forms.Button btn_Tic2;
        private System.Windows.Forms.Button btn_newGame;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label lbl_PayerX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_PlayerY;
        private System.Windows.Forms.Label label4;
    }
}

