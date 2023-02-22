namespace HQTCSDL
{
    partial class DOITAC_CH
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
            this.DATA = new System.Windows.Forms.DataGridView();
            this.cbbTT = new System.Windows.Forms.ComboBox();
            this.cbbSTT = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbTGMC = new System.Windows.Forms.ComboBox();
            this.cbbTGDC = new System.Windows.Forms.ComboBox();
            this.cbbDC = new System.Windows.Forms.ComboBox();
            this.cbbT = new System.Windows.Forms.ComboBox();
            this.TGDC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonT = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DATA)).BeginInit();
            this.SuspendLayout();
            // 
            // DATA
            // 
            this.DATA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DATA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DATA.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DATA.Location = new System.Drawing.Point(0, 627);
            this.DATA.Name = "DATA";
            this.DATA.RowHeadersWidth = 51;
            this.DATA.RowTemplate.Height = 29;
            this.DATA.Size = new System.Drawing.Size(1612, 359);
            this.DATA.TabIndex = 45;
            this.DATA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATA_CellClick);
            // 
            // cbbTT
            // 
            this.cbbTT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbTT.FormattingEnabled = true;
            this.cbbTT.Items.AddRange(new object[] {
            "Bình Thường",
            "Tạm Nghỉ"});
            this.cbbTT.Location = new System.Drawing.Point(101, 315);
            this.cbbTT.Name = "cbbTT";
            this.cbbTT.Size = new System.Drawing.Size(250, 31);
            this.cbbTT.TabIndex = 85;
            // 
            // cbbSTT
            // 
            this.cbbSTT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbSTT.FormattingEnabled = true;
            this.cbbSTT.Location = new System.Drawing.Point(101, 192);
            this.cbbSTT.Name = "cbbSTT";
            this.cbbSTT.Size = new System.Drawing.Size(250, 31);
            this.cbbSTT.TabIndex = 84;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(101, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 80;
            this.label6.Text = "Tình Trạng";
            this.label6.UseMnemonic = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(101, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 23);
            this.label8.TabIndex = 76;
            this.label8.Text = "Số thứ tự";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1612, 100);
            this.label3.TabIndex = 92;
            this.label3.Text = "CỬA HÀNG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(101, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 23);
            this.label7.TabIndex = 81;
            this.label7.Text = "Thời Gian Mở Cửa";
            // 
            // cbbTGMC
            // 
            this.cbbTGMC.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbTGMC.FormattingEnabled = true;
            this.cbbTGMC.Location = new System.Drawing.Point(101, 426);
            this.cbbTGMC.Name = "cbbTGMC";
            this.cbbTGMC.Size = new System.Drawing.Size(250, 31);
            this.cbbTGMC.TabIndex = 89;
            // 
            // cbbTGDC
            // 
            this.cbbTGDC.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbTGDC.FormattingEnabled = true;
            this.cbbTGDC.Location = new System.Drawing.Point(524, 426);
            this.cbbTGDC.Name = "cbbTGDC";
            this.cbbTGDC.Size = new System.Drawing.Size(250, 31);
            this.cbbTGDC.TabIndex = 98;
            // 
            // cbbDC
            // 
            this.cbbDC.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbDC.FormattingEnabled = true;
            this.cbbDC.Items.AddRange(new object[] {
            "Tái Ký"});
            this.cbbDC.Location = new System.Drawing.Point(524, 315);
            this.cbbDC.Name = "cbbDC";
            this.cbbDC.Size = new System.Drawing.Size(250, 31);
            this.cbbDC.TabIndex = 97;
            // 
            // cbbT
            // 
            this.cbbT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbT.FormattingEnabled = true;
            this.cbbT.Location = new System.Drawing.Point(524, 192);
            this.cbbT.Name = "cbbT";
            this.cbbT.Size = new System.Drawing.Size(250, 31);
            this.cbbT.TabIndex = 96;
            // 
            // TGDC
            // 
            this.TGDC.AutoSize = true;
            this.TGDC.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TGDC.Location = new System.Drawing.Point(524, 390);
            this.TGDC.Name = "TGDC";
            this.TGDC.Size = new System.Drawing.Size(180, 23);
            this.TGDC.TabIndex = 95;
            this.TGDC.Text = "Thời Gian Đóng Cửa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(524, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 94;
            this.label2.Text = "Địa Chỉ";
            this.label2.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(524, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 23);
            this.label4.TabIndex = 93;
            this.label4.Text = "Tên";
            // 
            // buttonT
            // 
            this.buttonT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.buttonT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonT.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonT.ForeColor = System.Drawing.Color.White;
            this.buttonT.Location = new System.Drawing.Point(1021, 168);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(300, 75);
            this.buttonT.TabIndex = 99;
            this.buttonT.Text = "Thêm";
            this.buttonT.UseVisualStyleBackColor = false;
            this.buttonT.Click += new System.EventHandler(this.buttonT_Click);
            // 
            // buttonX
            // 
            this.buttonX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.buttonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonX.ForeColor = System.Drawing.Color.White;
            this.buttonX.Location = new System.Drawing.Point(1021, 279);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(300, 75);
            this.buttonX.TabIndex = 100;
            this.buttonX.Text = "Xoá";
            this.buttonX.UseVisualStyleBackColor = false;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // buttonS
            // 
            this.buttonS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.buttonS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonS.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonS.ForeColor = System.Drawing.Color.White;
            this.buttonS.Location = new System.Drawing.Point(1021, 390);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(300, 75);
            this.buttonS.TabIndex = 101;
            this.buttonS.Text = "Sửa";
            this.buttonS.UseVisualStyleBackColor = false;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // DOITAC_CH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 986);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonT);
            this.Controls.Add(this.cbbTGDC);
            this.Controls.Add(this.cbbDC);
            this.Controls.Add(this.cbbT);
            this.Controls.Add(this.TGDC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbTGMC);
            this.Controls.Add(this.cbbTT);
            this.Controls.Add(this.cbbSTT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DATA);
            this.Name = "DOITAC_CH";
            this.Text = "DOITAC_CH";
            this.Load += new System.EventHandler(this.DOITAC_CH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DATA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DATA;
        private ComboBox cbbTT;
        private ComboBox cbbSTT;
        private Label label6;
        private Label label8;
        private Label label3;
        private Label label7;
        private ComboBox cbbTGMC;
        private ComboBox cbbTGDC;
        private ComboBox cbbDC;
        private ComboBox cbbT;
        private Label TGDC;
        private Label label2;
        private Label label4;
        private Button buttonT;
        private Button buttonX;
        private Button buttonS;
    }
}