namespace HQTCSDL
{
    partial class TAIXE_CTDH
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.CHITIETDONHANG = new System.Windows.Forms.Label();
            this.TENSANPHAM = new System.Windows.Forms.Label();
            this.SOLUONG = new System.Windows.Forms.Label();
            this.GIABAN = new System.Windows.Forms.Label();
            this.DIACHIBAN = new System.Windows.Forms.Label();
            this.TENQUANBAN = new System.Windows.Forms.Label();
            this.Quaylai = new System.Windows.Forms.Button();
            this.DATA = new System.Windows.Forms.DataGridView();
            this.cbbT = new System.Windows.Forms.ComboBox();
            this.cbbTQ = new System.Windows.Forms.ComboBox();
            this.cbbG = new System.Windows.Forms.ComboBox();
            this.cbbDC = new System.Windows.Forms.ComboBox();
            this.cbbSL = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DATA)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 703);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // CHITIETDONHANG
            // 
            this.CHITIETDONHANG.Dock = System.Windows.Forms.DockStyle.Top;
            this.CHITIETDONHANG.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CHITIETDONHANG.Location = new System.Drawing.Point(4, 0);
            this.CHITIETDONHANG.Name = "CHITIETDONHANG";
            this.CHITIETDONHANG.Size = new System.Drawing.Size(1228, 46);
            this.CHITIETDONHANG.TabIndex = 2;
            this.CHITIETDONHANG.Text = "CHI TIẾT ĐƠN HÀNG";
            this.CHITIETDONHANG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TENSANPHAM
            // 
            this.TENSANPHAM.AutoSize = true;
            this.TENSANPHAM.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TENSANPHAM.Location = new System.Drawing.Point(40, 138);
            this.TENSANPHAM.Name = "TENSANPHAM";
            this.TENSANPHAM.Size = new System.Drawing.Size(148, 27);
            this.TENSANPHAM.TabIndex = 3;
            this.TENSANPHAM.Text = "Tên sản phẩm";
            // 
            // SOLUONG
            // 
            this.SOLUONG.AutoSize = true;
            this.SOLUONG.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SOLUONG.Location = new System.Drawing.Point(870, 138);
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Size = new System.Drawing.Size(98, 27);
            this.SOLUONG.TabIndex = 8;
            this.SOLUONG.Text = "Số lượng";
            // 
            // GIABAN
            // 
            this.GIABAN.AutoSize = true;
            this.GIABAN.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GIABAN.Location = new System.Drawing.Point(455, 138);
            this.GIABAN.Name = "GIABAN";
            this.GIABAN.Size = new System.Drawing.Size(85, 27);
            this.GIABAN.TabIndex = 6;
            this.GIABAN.Text = "Giá bán";
            // 
            // DIACHIBAN
            // 
            this.DIACHIBAN.AutoSize = true;
            this.DIACHIBAN.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DIACHIBAN.Location = new System.Drawing.Point(455, 229);
            this.DIACHIBAN.Name = "DIACHIBAN";
            this.DIACHIBAN.Size = new System.Drawing.Size(120, 27);
            this.DIACHIBAN.TabIndex = 18;
            this.DIACHIBAN.Text = "Địa chỉ bán";
            // 
            // TENQUANBAN
            // 
            this.TENQUANBAN.AutoSize = true;
            this.TENQUANBAN.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TENQUANBAN.Location = new System.Drawing.Point(40, 229);
            this.TENQUANBAN.Name = "TENQUANBAN";
            this.TENQUANBAN.Size = new System.Drawing.Size(145, 27);
            this.TENQUANBAN.TabIndex = 17;
            this.TENQUANBAN.Text = "Tên quán bán";
            // 
            // Quaylai
            // 
            this.Quaylai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Quaylai.FlatAppearance.BorderSize = 0;
            this.Quaylai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quaylai.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Quaylai.Location = new System.Drawing.Point(40, 49);
            this.Quaylai.Name = "Quaylai";
            this.Quaylai.Size = new System.Drawing.Size(130, 50);
            this.Quaylai.TabIndex = 21;
            this.Quaylai.Text = "Quay lại";
            this.Quaylai.UseVisualStyleBackColor = false;
            this.Quaylai.Click += new System.EventHandler(this.QUAYLAI_Click);
            // 
            // DATA
            // 
            this.DATA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DATA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DATA.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DATA.Location = new System.Drawing.Point(4, 373);
            this.DATA.Name = "DATA";
            this.DATA.RowHeadersWidth = 51;
            this.DATA.RowTemplate.Height = 29;
            this.DATA.Size = new System.Drawing.Size(1228, 330);
            this.DATA.TabIndex = 22;
            this.DATA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATA_CellClick);
            // 
            // cbbT
            // 
            this.cbbT.FormattingEnabled = true;
            this.cbbT.Location = new System.Drawing.Point(40, 174);
            this.cbbT.Name = "cbbT";
            this.cbbT.Size = new System.Drawing.Size(250, 28);
            this.cbbT.TabIndex = 23;
            // 
            // cbbTQ
            // 
            this.cbbTQ.FormattingEnabled = true;
            this.cbbTQ.Location = new System.Drawing.Point(40, 265);
            this.cbbTQ.Name = "cbbTQ";
            this.cbbTQ.Size = new System.Drawing.Size(250, 28);
            this.cbbTQ.TabIndex = 24;
            // 
            // cbbG
            // 
            this.cbbG.FormattingEnabled = true;
            this.cbbG.Location = new System.Drawing.Point(455, 168);
            this.cbbG.Name = "cbbG";
            this.cbbG.Size = new System.Drawing.Size(250, 28);
            this.cbbG.TabIndex = 25;
            // 
            // cbbDC
            // 
            this.cbbDC.FormattingEnabled = true;
            this.cbbDC.Location = new System.Drawing.Point(455, 259);
            this.cbbDC.Name = "cbbDC";
            this.cbbDC.Size = new System.Drawing.Size(250, 28);
            this.cbbDC.TabIndex = 26;
            // 
            // cbbSL
            // 
            this.cbbSL.FormattingEnabled = true;
            this.cbbSL.Location = new System.Drawing.Point(870, 168);
            this.cbbSL.Name = "cbbSL";
            this.cbbSL.Size = new System.Drawing.Size(250, 28);
            this.cbbSL.TabIndex = 27;
            // 
            // TAIXE_CTDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.cbbSL);
            this.Controls.Add(this.cbbDC);
            this.Controls.Add(this.cbbG);
            this.Controls.Add(this.cbbTQ);
            this.Controls.Add(this.cbbT);
            this.Controls.Add(this.DATA);
            this.Controls.Add(this.Quaylai);
            this.Controls.Add(this.DIACHIBAN);
            this.Controls.Add(this.TENQUANBAN);
            this.Controls.Add(this.SOLUONG);
            this.Controls.Add(this.GIABAN);
            this.Controls.Add(this.TENSANPHAM);
            this.Controls.Add(this.CHITIETDONHANG);
            this.Controls.Add(this.splitter1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TAIXE_CTDH";
            this.Text = "CHI TIET DON HANG";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DATA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private Label CHITIETDONHANG;
        private Label TENSANPHAM;
        private Label SOLUONG;
        private Label GIABAN;
        private Label DIACHIBAN;
        private Label TENQUANBAN;
        private Button Quaylai;
        private DataGridView DATA;
        private ComboBox cbbT;
        private ComboBox cbbTQ;
        private ComboBox cbbG;
        private ComboBox cbbDC;
        private ComboBox cbbSL;
    }
}