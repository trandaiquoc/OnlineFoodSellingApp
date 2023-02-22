namespace HQTCSDL
{
    partial class GIOHANG
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
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.cbbHTTT = new System.Windows.Forms.ComboBox();
            this.HTTT = new System.Windows.Forms.Label();
            this.cbbMMA = new System.Windows.Forms.ComboBox();
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
            this.DATA.Location = new System.Drawing.Point(0, 260);
            this.DATA.Name = "DATA";
            this.DATA.RowHeadersWidth = 51;
            this.DATA.RowTemplate.Height = 29;
            this.DATA.Size = new System.Drawing.Size(800, 190);
            this.DATA.TabIndex = 35;
            this.DATA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATA_CellClick);
            // 
            // buttonM
            // 
            this.buttonM.AutoSize = true;
            this.buttonM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.buttonM.FlatAppearance.BorderSize = 0;
            this.buttonM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonM.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonM.ForeColor = System.Drawing.Color.White;
            this.buttonM.Location = new System.Drawing.Point(590, 171);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(159, 50);
            this.buttonM.TabIndex = 43;
            this.buttonM.Text = "Xác nhận mua";
            this.buttonM.UseVisualStyleBackColor = false;
            this.buttonM.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // buttonT
            // 
            this.buttonT.AutoSize = true;
            this.buttonT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.buttonT.FlatAppearance.BorderSize = 0;
            this.buttonT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonT.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonT.ForeColor = System.Drawing.Color.White;
            this.buttonT.Location = new System.Drawing.Point(288, 171);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(234, 50);
            this.buttonT.TabIndex = 44;
            this.buttonT.Text = "Thoát";
            this.buttonT.UseVisualStyleBackColor = false;
            this.buttonT.Click += new System.EventHandler(this.buttonT_Click);
            // 
            // buttonX
            // 
            this.buttonX.AutoSize = true;
            this.buttonX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.buttonX.FlatAppearance.BorderSize = 0;
            this.buttonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonX.ForeColor = System.Drawing.Color.White;
            this.buttonX.Location = new System.Drawing.Point(42, 171);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(165, 50);
            this.buttonX.TabIndex = 45;
            this.buttonX.Text = "Xoá món";
            this.buttonX.UseVisualStyleBackColor = false;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // cbbHTTT
            // 
            this.cbbHTTT.FormattingEnabled = true;
            this.cbbHTTT.Items.AddRange(new object[] {
            "Thanh Toán Khi Nhận Hàng",
            "MOMO",
            "Banking"});
            this.cbbHTTT.Location = new System.Drawing.Point(288, 55);
            this.cbbHTTT.Name = "cbbHTTT";
            this.cbbHTTT.Size = new System.Drawing.Size(250, 28);
            this.cbbHTTT.TabIndex = 47;
            // 
            // HTTT
            // 
            this.HTTT.AutoSize = true;
            this.HTTT.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HTTT.Location = new System.Drawing.Point(288, 25);
            this.HTTT.Name = "HTTT";
            this.HTTT.Size = new System.Drawing.Size(222, 27);
            this.HTTT.TabIndex = 46;
            this.HTTT.Text = "Hình thức thanh toán";
            // 
            // cbbMMA
            // 
            this.cbbMMA.FormattingEnabled = true;
            this.cbbMMA.Location = new System.Drawing.Point(12, 12);
            this.cbbMMA.Name = "cbbMMA";
            this.cbbMMA.Size = new System.Drawing.Size(151, 28);
            this.cbbMMA.TabIndex = 48;
            // 
            // GIOHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbMMA);
            this.Controls.Add(this.cbbHTTT);
            this.Controls.Add(this.HTTT);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonT);
            this.Controls.Add(this.buttonM);
            this.Controls.Add(this.DATA);
            this.Name = "GIOHANG";
            this.Text = "GIOHANG";
            this.Load += new System.EventHandler(this.GIOHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DATA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DATA;
        private Button buttonM;
        private Button buttonT;
        private Button buttonX;
        private ComboBox cbbHTTT;
        private Label HTTT;
        private ComboBox cbbMMA;
    }
}