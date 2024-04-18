namespace Tic_Tac_toe_Game
{
    partial class SnakeGame2
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lab_Snake = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Eat = new System.Windows.Forms.Button();
            this.labSnake = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.lab_Buttton = new System.Windows.Forms.Label();
            this.btn_UP = new System.Windows.Forms.Button();
            this.btn_Right = new System.Windows.Forms.Button();
            this.btn_Down = new System.Windows.Forms.Button();
            this.btn_Left = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.lab_Snake);
            this.panel1.Location = new System.Drawing.Point(60, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 67);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.labSnake);
            this.panel2.Controls.Add(this.btn_Eat);
            this.panel2.Location = new System.Drawing.Point(60, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 327);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(316, 468);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 67);
            this.panel3.TabIndex = 1;
            // 
            // lab_Snake
            // 
            this.lab_Snake.AutoSize = true;
            this.lab_Snake.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Snake.Location = new System.Drawing.Point(187, 15);
            this.lab_Snake.Name = "lab_Snake";
            this.lab_Snake.Size = new System.Drawing.Size(259, 39);
            this.lab_Snake.TabIndex = 0;
            this.lab_Snake.Text = "Snake Game 2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(27, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(196, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_Eat
            // 
            this.btn_Eat.BackColor = System.Drawing.Color.Red;
            this.btn_Eat.Location = new System.Drawing.Point(409, 43);
            this.btn_Eat.Name = "btn_Eat";
            this.btn_Eat.Size = new System.Drawing.Size(27, 19);
            this.btn_Eat.TabIndex = 1;
            this.btn_Eat.UseVisualStyleBackColor = false;
            // 
            // labSnake
            // 
            this.labSnake.AutoSize = true;
            this.labSnake.BackColor = System.Drawing.Color.White;
            this.labSnake.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSnake.Location = new System.Drawing.Point(39, 17);
            this.labSnake.Name = "labSnake";
            this.labSnake.Size = new System.Drawing.Size(29, 18);
            this.labSnake.TabIndex = 2;
            this.labSnake.Text = "**=";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Left);
            this.panel4.Controls.Add(this.btn_Down);
            this.panel4.Controls.Add(this.btn_Right);
            this.panel4.Controls.Add(this.btn_UP);
            this.panel4.Controls.Add(this.lab_Buttton);
            this.panel4.Location = new System.Drawing.Point(68, 448);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(242, 109);
            this.panel4.TabIndex = 3;
            // 
            // lab_Buttton
            // 
            this.lab_Buttton.AutoSize = true;
            this.lab_Buttton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lab_Buttton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Buttton.Location = new System.Drawing.Point(67, 10);
            this.lab_Buttton.Name = "lab_Buttton";
            this.lab_Buttton.Size = new System.Drawing.Size(112, 20);
            this.lab_Buttton.TabIndex = 0;
            this.lab_Buttton.Text = " PLay Button";
            // 
            // btn_UP
            // 
            this.btn_UP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UP.Location = new System.Drawing.Point(15, 43);
            this.btn_UP.Name = "btn_UP";
            this.btn_UP.Size = new System.Drawing.Size(81, 28);
            this.btn_UP.TabIndex = 3;
            this.btn_UP.Text = "UP";
            this.btn_UP.UseVisualStyleBackColor = true;
            this.btn_UP.Click += new System.EventHandler(this.btn_UP_Click);
            // 
            // btn_Right
            // 
            this.btn_Right.Location = new System.Drawing.Point(112, 43);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(81, 28);
            this.btn_Right.TabIndex = 4;
            this.btn_Right.Text = ">";
            this.btn_Right.UseVisualStyleBackColor = true;
            this.btn_Right.Click += new System.EventHandler(this.btn_Right_Click);
            // 
            // btn_Down
            // 
            this.btn_Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Down.Location = new System.Drawing.Point(15, 81);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(81, 28);
            this.btn_Down.TabIndex = 5;
            this.btn_Down.Text = "Down";
            this.btn_Down.UseVisualStyleBackColor = true;
            // 
            // btn_Left
            // 
            this.btn_Left.Location = new System.Drawing.Point(112, 81);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(81, 28);
            this.btn_Left.TabIndex = 6;
            this.btn_Left.Text = "<";
            this.btn_Left.UseVisualStyleBackColor = true;
            // 
            // SnakeGame2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SnakeGame2";
            this.Text = "SnakeGame2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lab_Snake;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Eat;
        private System.Windows.Forms.Label labSnake;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lab_Buttton;
        private System.Windows.Forms.Button btn_Left;
        private System.Windows.Forms.Button btn_Down;
        private System.Windows.Forms.Button btn_Right;
        private System.Windows.Forms.Button btn_UP;
    }
}