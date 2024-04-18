namespace Game_Tic_tac_toe
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_Tic1 = new System.Windows.Forms.Button();
            this.btn_Tic2 = new System.Windows.Forms.Button();
            this.btn_Tic3 = new System.Windows.Forms.Button();
            this.btn_Tic4 = new System.Windows.Forms.Button();
            this.btn_Tic5 = new System.Windows.Forms.Button();
            this.btn_Tic6 = new System.Windows.Forms.Button();
            this.btn_Tic7 = new System.Windows.Forms.Button();
            this.btn_Tic8 = new System.Windows.Forms.Button();
            this.btn_Tic9 = new System.Windows.Forms.Button();
            this.lab_Game = new System.Windows.Forms.Label();
            this.btn_Game = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.lab_Game);
            this.panel1.Location = new System.Drawing.Point(38, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 82);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.btn_Tic9);
            this.panel2.Controls.Add(this.btn_Tic8);
            this.panel2.Controls.Add(this.btn_Tic7);
            this.panel2.Controls.Add(this.btn_Tic6);
            this.panel2.Controls.Add(this.btn_Tic5);
            this.panel2.Controls.Add(this.btn_Tic4);
            this.panel2.Controls.Add(this.btn_Tic3);
            this.panel2.Controls.Add(this.btn_Tic2);
            this.panel2.Controls.Add(this.btn_Tic1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(38, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 341);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Blue;
            this.panel5.Controls.Add(this.btn_Exit);
            this.panel5.Controls.Add(this.btn_Reset);
            this.panel5.Controls.Add(this.btn_Game);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(522, 257);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(316, 207);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(439, 144);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(320, 191);
            this.panel6.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(433, 107);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(317, 231);
            this.panel7.TabIndex = 1;
            // 
            // btn_Tic1
            // 
            this.btn_Tic1.Location = new System.Drawing.Point(18, 19);
            this.btn_Tic1.Name = "btn_Tic1";
            this.btn_Tic1.Size = new System.Drawing.Size(114, 88);
            this.btn_Tic1.TabIndex = 0;
            this.btn_Tic1.UseVisualStyleBackColor = true;
            this.btn_Tic1.Click += new System.EventHandler(this.btn_Tic1_Click);
            // 
            // btn_Tic2
            // 
            this.btn_Tic2.Location = new System.Drawing.Point(137, 19);
            this.btn_Tic2.Name = "btn_Tic2";
            this.btn_Tic2.Size = new System.Drawing.Size(109, 88);
            this.btn_Tic2.TabIndex = 1;
            this.btn_Tic2.UseVisualStyleBackColor = true;
            this.btn_Tic2.Click += new System.EventHandler(this.btn_Tic2_Click);
            // 
            // btn_Tic3
            // 
            this.btn_Tic3.Location = new System.Drawing.Point(252, 19);
            this.btn_Tic3.Name = "btn_Tic3";
            this.btn_Tic3.Size = new System.Drawing.Size(113, 88);
            this.btn_Tic3.TabIndex = 2;
            this.btn_Tic3.UseVisualStyleBackColor = true;
            this.btn_Tic3.Click += new System.EventHandler(this.btn_Tic3_Click);
            // 
            // btn_Tic4
            // 
            this.btn_Tic4.Location = new System.Drawing.Point(18, 113);
            this.btn_Tic4.Name = "btn_Tic4";
            this.btn_Tic4.Size = new System.Drawing.Size(113, 91);
            this.btn_Tic4.TabIndex = 3;
            this.btn_Tic4.UseVisualStyleBackColor = true;
            this.btn_Tic4.Click += new System.EventHandler(this.btn_Tic4_Click);
            // 
            // btn_Tic5
            // 
            this.btn_Tic5.Location = new System.Drawing.Point(137, 113);
            this.btn_Tic5.Name = "btn_Tic5";
            this.btn_Tic5.Size = new System.Drawing.Size(113, 91);
            this.btn_Tic5.TabIndex = 4;
            this.btn_Tic5.UseVisualStyleBackColor = true;
            this.btn_Tic5.Click += new System.EventHandler(this.btn_Tic5_Click);
            // 
            // btn_Tic6
            // 
            this.btn_Tic6.Location = new System.Drawing.Point(252, 113);
            this.btn_Tic6.Name = "btn_Tic6";
            this.btn_Tic6.Size = new System.Drawing.Size(113, 91);
            this.btn_Tic6.TabIndex = 5;
            this.btn_Tic6.UseVisualStyleBackColor = true;
            this.btn_Tic6.Click += new System.EventHandler(this.btn_Tic6_Click);
            // 
            // btn_Tic7
            // 
            this.btn_Tic7.Location = new System.Drawing.Point(18, 210);
            this.btn_Tic7.Name = "btn_Tic7";
            this.btn_Tic7.Size = new System.Drawing.Size(113, 91);
            this.btn_Tic7.TabIndex = 6;
            this.btn_Tic7.UseVisualStyleBackColor = true;
            this.btn_Tic7.Click += new System.EventHandler(this.btn_Tic7_Click);
            // 
            // btn_Tic8
            // 
            this.btn_Tic8.Location = new System.Drawing.Point(137, 210);
            this.btn_Tic8.Name = "btn_Tic8";
            this.btn_Tic8.Size = new System.Drawing.Size(113, 91);
            this.btn_Tic8.TabIndex = 7;
            this.btn_Tic8.UseVisualStyleBackColor = true;
            this.btn_Tic8.Click += new System.EventHandler(this.btn_Tic8_Click);
            // 
            // btn_Tic9
            // 
            this.btn_Tic9.Location = new System.Drawing.Point(252, 210);
            this.btn_Tic9.Name = "btn_Tic9";
            this.btn_Tic9.Size = new System.Drawing.Size(113, 91);
            this.btn_Tic9.TabIndex = 8;
            this.btn_Tic9.UseVisualStyleBackColor = true;
            this.btn_Tic9.Click += new System.EventHandler(this.btn_Tic9_Click);
            // 
            // lab_Game
            // 
            this.lab_Game.AutoSize = true;
            this.lab_Game.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Game.Location = new System.Drawing.Point(98, 18);
            this.lab_Game.Name = "lab_Game";
            this.lab_Game.Size = new System.Drawing.Size(368, 46);
            this.lab_Game.TabIndex = 0;
            this.lab_Game.Text = "Tic Tac Toe  Game 1";
            // 
            // btn_Game
            // 
            this.btn_Game.Location = new System.Drawing.Point(3, 67);
            this.btn_Game.Name = "btn_Game";
            this.btn_Game.Size = new System.Drawing.Size(293, 56);
            this.btn_Game.TabIndex = 9;
            this.btn_Game.Text = " New Game";
            this.btn_Game.UseVisualStyleBackColor = true;
            this.btn_Game.Click += new System.EventHandler(this.btn_Game_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(3, 129);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(132, 62);
            this.btn_Reset.TabIndex = 9;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(151, 129);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(132, 62);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(883, 583);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "-";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_Tic2;
        private System.Windows.Forms.Button btn_Tic1;
        private System.Windows.Forms.Button btn_Tic9;
        private System.Windows.Forms.Button btn_Tic8;
        private System.Windows.Forms.Button btn_Tic7;
        private System.Windows.Forms.Button btn_Tic6;
        private System.Windows.Forms.Button btn_Tic5;
        private System.Windows.Forms.Button btn_Tic4;
        private System.Windows.Forms.Button btn_Tic3;
        private System.Windows.Forms.Label lab_Game;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Game;
    }
}

