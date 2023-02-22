namespace HQTCSDL
{
    partial class KHACHHANG_CTDH
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
            this.CHITIETDONHANG = new System.Windows.Forms.Label();
            this.cbbSL = new System.Windows.Forms.ComboBox();
            this.cbbG = new System.Windows.Forms.ComboBox();
            this.cbbTQ = new System.Windows.Forms.ComboBox();
            this.cbbT = new System.Windows.Forms.ComboBox();
            this.DATA = new System.Windows.Forms.DataGridView();
            this.Quaylai = new System.Windows.Forms.Button();
            this.TENQUANBAN = new System.Windows.Forms.Label();
            this.SOLUONG = new System.Windows.Forms.Label();
            this.GIABAN = new System.Windows.Forms.Label();
            this.TENSANPHAM = new System.Windows.Forms.Label();
            this.DANHGIA = new System.Windows.Forms.Label();
            this.cbbDG = new System.Windows.Forms.ComboBox();
            this.buttonDG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DATA)).BeginInit();
            this.SuspendLayout();
            // 
            // CHITIETDONHANG
            // 
            this.CHITIETDONHANG.Dock = System.Windows.Forms.DockStyle.Top;
            this.CHITIETDONHANG.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CHITIETDONHANG.Location = new System.Drawing.Point(0, 0);
            this.CHITIETDONHANG.Name = "CHITIETDONHANG";
            this.CHITIETDONHANG.Size = new System.Drawing.Size(1232, 46);
            this.CHITIETDONHANG.TabIndex = 3;
            this.CHITIETDONHANG.Text = "CHI TIẾT ĐƠN HÀNG";
            this.CHITIETDONHANG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbSL
            // 
            this.cbbSL.FormattingEnabled = true;
            this.cbbSL.Location = new System.Drawing.Point(870, 143);
            this.cbbSL.Name = "cbbSL";
            this.cbbSL.Size = new System.Drawing.Size(250, 28);
            this.cbbSL.TabIndex = 39;
            // 
            // cbbG
            // 
            this.cbbG.FormattingEnabled = true;
            this.cbbG.Location = new System.Drawing.Point(455, 143);
            this.cbbG.Name = "cbbG";
            this.cbbG.Size = new System.Drawing.Size(250, 28);
            this.cbbG.TabIndex = 37;
            // 
            // cbbTQ
            // 
            this.cbbTQ.FormattingEnabled = true;
            this.cbbTQ.Location = new System.Drawing.Point(40, 240);
            this.cbbTQ.Name = "cbbTQ";
            this.cbbTQ.Size = new System.Drawing.Size(250, 28);
            this.cbbTQ.TabIndex = 36;
            // 
            // cbbT
            // 
            this.cbbT.FormattingEnabled = true;
            this.cbbT.Location = new System.Drawing.Point(40, 149);
            this.cbbT.Name = "cbbT";
            this.cbbT.Size = new System.Drawing.Size(250, 28);
            this.cbbT.TabIndex = 35;
            // 
            // DATA
            // 
            this.DATA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DATA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DATA.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DATA.Location = new System.Drawing.Point(0, 373);
            this.DATA.Name = "DATA";
            this.DATA.RowHeadersWidth = 51;
            this.DATA.RowTemplate.Height = 29;
            this.DATA.Size = new System.Drawing.Size(1232, 330);
            this.DATA.TabIndex = 34;
            this.DATA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATA_CellClick);
            // 
            // Quaylai
            // 
            this.Quaylai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Quaylai.FlatAppearance.BorderSize = 0;
            this.Quaylai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quaylai.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Quaylai.Location = new System.Drawing.Point(40, 24);
            this.Quaylai.Name = "Quaylai";
            this.Quaylai.Size = new System.Drawing.Size(130, 50);
            this.Quaylai.TabIndex = 33;
            this.Quaylai.Text = "Quay lại";
            this.Quaylai.UseVisualStyleBackColor = false;
            this.Quaylai.Click += new System.EventHandler(this.Quaylai_Click_1);
            // 
            // TENQUANBAN
            // 
            this.TENQUANBAN.AutoSize = true;
            this.TENQUANBAN.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TENQUANBAN.Location = new System.Drawing.Point(40, 204);
            this.TENQUANBAN.Name = "TENQUANBAN";
            this.TENQUANBAN.Size = new System.Drawing.Size(145, 27);
            this.TENQUANBAN.TabIndex = 31;
            this.TENQUANBAN.Text = "Tên quán bán";
            // 
            // SOLUONG
            // 
            this.SOLUONG.AutoSize = true;
            this.SOLUONG.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SOLUONG.Location = new System.Drawing.Point(870, 113);
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Size = new System.Drawing.Size(98, 27);
            this.SOLUONG.TabIndex = 30;
            this.SOLUONG.Text = "Số lượng";
            // 
            // GIABAN
            // 
            this.GIABAN.AutoSize = true;
            this.GIABAN.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GIABAN.Location = new System.Drawing.Point(455, 113);
            this.GIABAN.Name = "GIABAN";
            this.GIABAN.Size = new System.Drawing.Size(85, 27);
            this.GIABAN.TabIndex = 29;
            this.GIABAN.Text = "Giá bán";
            // 
            // TENSANPHAM
            // 
            this.TENSANPHAM.AutoSize = true;
            this.TENSANPHAM.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TENSANPHAM.Location = new System.Drawing.Point(40, 113);
            this.TENSANPHAM.Name = "TENSANPHAM";
            this.TENSANPHAM.Size = new System.Drawing.Size(148, 27);
            this.TENSANPHAM.TabIndex = 28;
            this.TENSANPHAM.Text = "Tên sản phẩm";
            // 
            // DANHGIA
            // 
            this.DANHGIA.AutoSize = true;
            this.DANHGIA.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DANHGIA.Location = new System.Drawing.Point(455, 204);
            this.DANHGIA.Name = "DANHGIA";
            this.DANHGIA.Size = new System.Drawing.Size(100, 27);
            this.DANHGIA.TabIndex = 32;
            this.DANHGIA.Text = "Đánh Giá";
            // 
            // cbbDG
            // 
            this.cbbDG.FormattingEnabled = true;
            this.cbbDG.Location = new System.Drawing.Point(455, 234);
            this.cbbDG.Name = "cbbDG";
            this.cbbDG.Size = new System.Drawing.Size(250, 28);
            this.cbbDG.TabIndex = 38;
            // 
            // buttonDG
            // 
            this.buttonDG.AutoSize = true;
            this.buttonDG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.buttonDG.FlatAppearance.BorderSize = 0;
            this.buttonDG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDG.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDG.ForeColor = System.Drawing.Color.White;
            this.buttonDG.Location = new System.Drawing.Point(870, 212);
            this.buttonDG.Name = "buttonDG";
            this.buttonDG.Size = new System.Drawing.Size(204, 50);
            this.buttonDG.TabIndex = 40;
            this.buttonDG.Text = "Xác nhận Đánh Giá";
            this.buttonDG.UseVisualStyleBackColor = false;
            this.buttonDG.Click += new System.EventHandler(this.buttonDG_Click);
            // 
            // KHACHHANG_CTDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.buttonDG);
            this.Controls.Add(this.cbbSL);
            this.Controls.Add(this.cbbDG);
            this.Controls.Add(this.cbbG);
            this.Controls.Add(this.cbbTQ);
            this.Controls.Add(this.cbbT);
            this.Controls.Add(this.DATA);
            this.Controls.Add(this.Quaylai);
            this.Controls.Add(this.DANHGIA);
            this.Controls.Add(this.TENQUANBAN);
            this.Controls.Add(this.SOLUONG);
            this.Controls.Add(this.GIABAN);
            this.Controls.Add(this.TENSANPHAM);
            this.Controls.Add(this.CHITIETDONHANG);
            this.Name = "KHACHHANG_CTDH";
            this.Text = "KHACHHANG_CTDH";
            this.Load += new System.EventHandler(this.KHACHHANG_CTDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DATA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CHITIETDONHANG;
        private ComboBox cbbSL;
        private ComboBox cbbG;
        private ComboBox cbbTQ;
        private ComboBox cbbT;
        private DataGridView DATA;
        private Button Quaylai;
        private Label TENQUANBAN;
        private Label SOLUONG;
        private Label GIABAN;
        private Label TENSANPHAM;
        private Label DANHGIA;
        private ComboBox cbbDG;
        private Button buttonDG;
    }
}