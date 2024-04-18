namespace SnakeGame
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
            this.components = new System.ComponentModel.Container();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_Snap = new System.Windows.Forms.Button();
            this.Pic_Canvas = new System.Windows.Forms.PictureBox();
            this.tex_HighScore = new System.Windows.Forms.Label();
            this.tex_Score = new System.Windows.Forms.Label();
            this.GameTimer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Lime;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(628, 46);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(128, 55);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_Snap
            // 
            this.btn_Snap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Snap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Snap.Location = new System.Drawing.Point(628, 107);
            this.btn_Snap.Name = "btn_Snap";
            this.btn_Snap.Size = new System.Drawing.Size(128, 55);
            this.btn_Snap.TabIndex = 1;
            this.btn_Snap.Text = "Snap";
            this.btn_Snap.UseVisualStyleBackColor = false;
            this.btn_Snap.Click += new System.EventHandler(this.btn_Snap_Click);
            // 
            // Pic_Canvas
            // 
            this.Pic_Canvas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Pic_Canvas.Location = new System.Drawing.Point(42, 12);
            this.Pic_Canvas.Name = "Pic_Canvas";
            this.Pic_Canvas.Size = new System.Drawing.Size(580, 680);
            this.Pic_Canvas.TabIndex = 2;
            this.Pic_Canvas.TabStop = false;
            this.Pic_Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureGrphics);
            // 
            // tex_HighScore
            // 
            this.tex_HighScore.AutoSize = true;
            this.tex_HighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_HighScore.Location = new System.Drawing.Point(628, 218);
            this.tex_HighScore.Name = "tex_HighScore";
            this.tex_HighScore.Size = new System.Drawing.Size(92, 18);
            this.tex_HighScore.TabIndex = 3;
            this.tex_HighScore.Text = "High Score";
            // 
            // tex_Score
            // 
            this.tex_Score.AutoSize = true;
            this.tex_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_Score.Location = new System.Drawing.Point(625, 178);
            this.tex_Score.Name = "tex_Score";
            this.tex_Score.Size = new System.Drawing.Size(67, 18);
            this.tex_Score.TabIndex = 4;
            this.tex_Score.Text = "Score 0";
            // 
            // GameTimer1
            // 
            this.GameTimer1.Interval = 40;
            this.GameTimer1.Tick += new System.EventHandler(this.GameTimeEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.tex_Score);
            this.Controls.Add(this.tex_HighScore);
            this.Controls.Add(this.Pic_Canvas);
            this.Controls.Add(this.btn_Snap);
            this.Controls.Add(this.btn_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_Snap;
        private System.Windows.Forms.PictureBox Pic_Canvas;
        private System.Windows.Forms.Label tex_HighScore;
        private System.Windows.Forms.Label tex_Score;
        private System.Windows.Forms.Timer GameTimer1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

