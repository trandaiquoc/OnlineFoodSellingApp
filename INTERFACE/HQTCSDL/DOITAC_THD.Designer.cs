namespace HQTCSDL
{
    partial class DOITAC_THD
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
            this.cbbCNNH = new System.Windows.Forms.ComboBox();
            this.cbbNH = new System.Windows.Forms.ComboBox();
            this.cbbSTK = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbCNNH
            // 
            this.cbbCNNH.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbCNNH.FormattingEnabled = true;
            this.cbbCNNH.Location = new System.Drawing.Point(1031, 382);
            this.cbbCNNH.Name = "cbbCNNH";
            this.cbbCNNH.Size = new System.Drawing.Size(250, 31);
            this.cbbCNNH.TabIndex = 78;
            // 
            // cbbNH
            // 
            this.cbbNH.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbNH.FormattingEnabled = true;
            this.cbbNH.Location = new System.Drawing.Point(674, 382);
            this.cbbNH.Name = "cbbNH";
            this.cbbNH.Size = new System.Drawing.Size(250, 31);
            this.cbbNH.TabIndex = 77;
            // 
            // cbbSTK
            // 
            this.cbbSTK.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbSTK.FormattingEnabled = true;
            this.cbbSTK.Location = new System.Drawing.Point(312, 382);
            this.cbbSTK.Name = "cbbSTK";
            this.cbbSTK.Size = new System.Drawing.Size(250, 31);
            this.cbbSTK.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1031, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 23);
            this.label4.TabIndex = 75;
            this.label4.Text = "Chi nhánh Ngân hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(674, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 74;
            this.label2.Text = "Ngân Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(312, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 23);
            this.label1.TabIndex = 73;
            this.label1.Text = "Số Tài Khoản của Đối tác";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1584, 100);
            this.label3.TabIndex = 79;
            this.label3.Text = "THÊM HỢP ĐỒNG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDK
            // 
            this.buttonDK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.buttonDK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDK.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDK.ForeColor = System.Drawing.Color.White;
            this.buttonDK.Location = new System.Drawing.Point(651, 508);
            this.buttonDK.Name = "buttonDK";
            this.buttonDK.Size = new System.Drawing.Size(300, 75);
            this.buttonDK.TabIndex = 85;
            this.buttonDK.Text = "Đăng Ký";
            this.buttonDK.UseVisualStyleBackColor = false;
            this.buttonDK.Click += new System.EventHandler(this.buttonDK_Click);
            // 
            // DOITAC_THD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 986);
            this.Controls.Add(this.buttonDK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbCNNH);
            this.Controls.Add(this.cbbNH);
            this.Controls.Add(this.cbbSTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DOITAC_THD";
            this.Text = "DOITAC_THD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbbCNNH;
        private ComboBox cbbNH;
        private ComboBox cbbSTK;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button buttonDK;
    }
}