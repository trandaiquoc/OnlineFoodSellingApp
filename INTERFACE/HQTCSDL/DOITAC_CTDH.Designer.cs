namespace HQTCSDL
{
    partial class DOITAC_CTDH
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbbT = new System.Windows.Forms.ComboBox();
            this.cbbSL = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonQL = new System.Windows.Forms.Button();
            this.DATA = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DATA)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(57, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 105;
            this.label4.Text = "Tên Món";
            // 
            // cbbT
            // 
            this.cbbT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbT.FormattingEnabled = true;
            this.cbbT.Location = new System.Drawing.Point(57, 59);
            this.cbbT.Name = "cbbT";
            this.cbbT.Size = new System.Drawing.Size(250, 31);
            this.cbbT.TabIndex = 106;
            // 
            // cbbSL
            // 
            this.cbbSL.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbSL.FormattingEnabled = true;
            this.cbbSL.Location = new System.Drawing.Point(457, 59);
            this.cbbSL.Name = "cbbSL";
            this.cbbSL.Size = new System.Drawing.Size(250, 31);
            this.cbbSL.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(457, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 107;
            this.label1.Text = "Số lượng món";
            // 
            // buttonQL
            // 
            this.buttonQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.buttonQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQL.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonQL.ForeColor = System.Drawing.Color.White;
            this.buttonQL.Location = new System.Drawing.Point(234, 752);
            this.buttonQL.Name = "buttonQL";
            this.buttonQL.Size = new System.Drawing.Size(300, 75);
            this.buttonQL.TabIndex = 109;
            this.buttonQL.Text = "Quay lại";
            this.buttonQL.UseVisualStyleBackColor = false;
            this.buttonQL.Click += new System.EventHandler(this.buttonQL_Click);
            // 
            // DATA
            // 
            this.DATA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DATA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DATA.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATA.Location = new System.Drawing.Point(-9, 125);
            this.DATA.Name = "DATA";
            this.DATA.RowHeadersWidth = 51;
            this.DATA.RowTemplate.Height = 29;
            this.DATA.Size = new System.Drawing.Size(801, 588);
            this.DATA.TabIndex = 110;
            this.DATA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATA_CellClick);
            // 
            // DOITAC_CTDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 839);
            this.Controls.Add(this.DATA);
            this.Controls.Add(this.buttonQL);
            this.Controls.Add(this.cbbSL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbT);
            this.Controls.Add(this.label4);
            this.Name = "DOITAC_CTDH";
            this.Text = "DOITAC_CTDH";
            this.Load += new System.EventHandler(this.DOITAC_CTDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DATA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private ComboBox cbbT;
        private ComboBox cbbSL;
        private Label label1;
        private Button buttonQL;
        private DataGridView DATA;
    }
}