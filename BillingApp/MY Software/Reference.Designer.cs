namespace MY_Software
{
    partial class Reference
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lab_Reference = new System.Windows.Forms.Label();
            this.tn_Cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Submit.Location = new System.Drawing.Point(132, 236);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(144, 45);
            this.btn_Submit.TabIndex = 0;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(56, 88);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(485, 130);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // lab_Reference
            // 
            this.lab_Reference.AutoSize = true;
            this.lab_Reference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lab_Reference.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lab_Reference.Location = new System.Drawing.Point(186, 39);
            this.lab_Reference.Name = "lab_Reference";
            this.lab_Reference.Size = new System.Drawing.Size(200, 25);
            this.lab_Reference.TabIndex = 2;
            this.lab_Reference.Text = "Reference Details";
            // 
            // tn_Cancel
            // 
            this.tn_Cancel.BackColor = System.Drawing.Color.Red;
            this.tn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tn_Cancel.ForeColor = System.Drawing.Color.Yellow;
            this.tn_Cancel.Location = new System.Drawing.Point(341, 236);
            this.tn_Cancel.Name = "tn_Cancel";
            this.tn_Cancel.Size = new System.Drawing.Size(144, 45);
            this.tn_Cancel.TabIndex = 3;
            this.tn_Cancel.Text = "Cancel";
            this.tn_Cancel.UseVisualStyleBackColor = false;
            this.tn_Cancel.Click += new System.EventHandler(this.tn_Cancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.tn_Cancel);
            this.panel1.Controls.Add(this.lab_Reference);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.btn_Submit);
            this.panel1.Location = new System.Drawing.Point(81, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 337);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Reference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Reference";
            this.Text = "Reference";
            this.Load += new System.EventHandler(this.Reference_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lab_Reference;
        private System.Windows.Forms.Button tn_Cancel;
        private System.Windows.Forms.Panel panel1;
    }
}