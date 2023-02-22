namespace HQTCSDL
{
    partial class KHACHHANG_MA
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
            this.cbbMT = new System.Windows.Forms.ComboBox();
            this.cbbG = new System.Windows.Forms.ComboBox();
            this.cbbT = new System.Windows.Forms.ComboBox();
            this.DATA = new System.Windows.Forms.DataGridView();
            this.Quaylai = new System.Windows.Forms.Button();
            this.MIEUTA = new System.Windows.Forms.Label();
            this.GIABAN = new System.Windows.Forms.Label();
            this.TENSANPHAM = new System.Windows.Forms.Label();
            this.cbbTT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonM = new System.Windows.Forms.Button();
            this.cbbMMA = new System.Windows.Forms.ComboBox();
            this.buttonGH = new System.Windows.Forms.Button();
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
            // cbbMT
            // 
            this.cbbMT.FormattingEnabled = true;
            this.cbbMT.Location = new System.Drawing.Point(872, 203);
            this.cbbMT.Name = "cbbMT";
            this.cbbMT.Size = new System.Drawing.Size(250, 28);
            this.cbbMT.TabIndex = 39;
            // 
            // cbbG
            // 
            this.cbbG.FormattingEnabled = true;
            this.cbbG.Location = new System.Drawing.Point(457, 203);
            this.cbbG.Name = "cbbG";
            this.cbbG.Size = new System.Drawing.Size(250, 28);
            this.cbbG.TabIndex = 37;
            // 
            // cbbT
            // 
            this.cbbT.FormattingEnabled = true;
            this.cbbT.Location = new System.Drawing.Point(42, 209);
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
            this.Quaylai.Location = new System.Drawing.Point(42, 84);
            this.Quaylai.Name = "Quaylai";
            this.Quaylai.Size = new System.Drawing.Size(130, 50);
            this.Quaylai.TabIndex = 33;
            this.Quaylai.Text = "Quay lại";
            this.Quaylai.UseVisualStyleBackColor = false;
            this.Quaylai.Click += new System.EventHandler(this.Quaylai_Click);
            // 
            // MIEUTA
            // 
            this.MIEUTA.AutoSize = true;
            this.MIEUTA.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MIEUTA.Location = new System.Drawing.Point(872, 173);
            this.MIEUTA.Name = "MIEUTA";
            this.MIEUTA.Size = new System.Drawing.Size(85, 27);
            this.MIEUTA.TabIndex = 30;
            this.MIEUTA.Text = "Miêu tả";
            // 
            // GIABAN
            // 
            this.GIABAN.AutoSize = true;
            this.GIABAN.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GIABAN.Location = new System.Drawing.Point(457, 173);
            this.GIABAN.Name = "GIABAN";
            this.GIABAN.Size = new System.Drawing.Size(85, 27);
            this.GIABAN.TabIndex = 29;
            this.GIABAN.Text = "Giá bán";
            // 
            // TENSANPHAM
            // 
            this.TENSANPHAM.AutoSize = true;
            this.TENSANPHAM.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TENSANPHAM.Location = new System.Drawing.Point(42, 173);
            this.TENSANPHAM.Name = "TENSANPHAM";
            this.TENSANPHAM.Size = new System.Drawing.Size(148, 27);
            this.TENSANPHAM.TabIndex = 28;
            this.TENSANPHAM.Text = "Tên sản phẩm";
            // 
            // cbbTT
            // 
            this.cbbTT.FormattingEnabled = true;
            this.cbbTT.Location = new System.Drawing.Point(42, 291);
            this.cbbTT.Name = "cbbTT";
            this.cbbTT.Size = new System.Drawing.Size(250, 28);
            this.cbbTT.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 27);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tình trạng bán";
            // 
            // buttonM
            // 
            this.buttonM.AutoSize = true;
            this.buttonM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.buttonM.FlatAppearance.BorderSize = 0;
            this.buttonM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonM.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonM.ForeColor = System.Drawing.Color.White;
            this.buttonM.Location = new System.Drawing.Point(457, 269);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(130, 50);
            this.buttonM.TabIndex = 42;
            this.buttonM.Text = "Mua";
            this.buttonM.UseVisualStyleBackColor = false;
            this.buttonM.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // cbbMMA
            // 
            this.cbbMMA.FormattingEnabled = true;
            this.cbbMMA.Location = new System.Drawing.Point(970, 14);
            this.cbbMMA.Name = "cbbMMA";
            this.cbbMMA.Size = new System.Drawing.Size(250, 28);
            this.cbbMMA.TabIndex = 43;
            // 
            // buttonGH
            // 
            this.buttonGH.AutoSize = true;
            this.buttonGH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.buttonGH.FlatAppearance.BorderSize = 0;
            this.buttonGH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGH.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGH.ForeColor = System.Drawing.Color.White;
            this.buttonGH.Location = new System.Drawing.Point(872, 269);
            this.buttonGH.Name = "buttonGH";
            this.buttonGH.Size = new System.Drawing.Size(130, 50);
            this.buttonGH.TabIndex = 44;
            this.buttonGH.Text = "Giỏ Hàng";
            this.buttonGH.UseVisualStyleBackColor = false;
            this.buttonGH.Click += new System.EventHandler(this.buttonGH_Click);
            // 
            // KHACHHANG_MA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.buttonGH);
            this.Controls.Add(this.cbbMMA);
            this.Controls.Add(this.buttonM);
            this.Controls.Add(this.cbbTT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbMT);
            this.Controls.Add(this.cbbG);
            this.Controls.Add(this.cbbT);
            this.Controls.Add(this.DATA);
            this.Controls.Add(this.Quaylai);
            this.Controls.Add(this.MIEUTA);
            this.Controls.Add(this.GIABAN);
            this.Controls.Add(this.TENSANPHAM);
            this.Controls.Add(this.CHITIETDONHANG);
            this.Name = "KHACHHANG_MA";
            this.Text = "KHACHHANG_MA";
            this.Load += new System.EventHandler(this.KHACHHANG_MA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DATA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CHITIETDONHANG;
        private ComboBox cbbMT;
        private ComboBox cbbG;
        private ComboBox cbbT;
        private DataGridView DATA;
        private Button Quaylai;
        private Label MIEUTA;
        private Label GIABAN;
        private Label TENSANPHAM;
        private ComboBox cbbTT;
        private Label label1;
        private Button buttonM;
        private ComboBox cbbMMA;
        private Button buttonGH;
    }
}