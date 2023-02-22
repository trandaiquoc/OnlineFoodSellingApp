namespace HQTCSDL
{
    partial class DOITAC_DH
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel_left = new System.Windows.Forms.Panel();
            this.cbbMDH = new System.Windows.Forms.ComboBox();
            this.buttonX1 = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.DATA1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_right = new System.Windows.Forms.Panel();
            this.buttonX2 = new System.Windows.Forms.Button();
            this.DATA2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATA1)).BeginInit();
            this.panel_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATA2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1602, 100);
            this.label3.TabIndex = 93;
            this.label3.Text = "QUẢN LÝ ĐƠN HÀNG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_left
            // 
            this.panel_left.Controls.Add(this.cbbMDH);
            this.panel_left.Controls.Add(this.buttonX1);
            this.panel_left.Controls.Add(this.buttonS);
            this.panel_left.Controls.Add(this.DATA1);
            this.panel_left.Controls.Add(this.label1);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 100);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(801, 886);
            this.panel_left.TabIndex = 94;
            // 
            // cbbMDH
            // 
            this.cbbMDH.FormattingEnabled = true;
            this.cbbMDH.Location = new System.Drawing.Point(730, 24);
            this.cbbMDH.Name = "cbbMDH";
            this.cbbMDH.Size = new System.Drawing.Size(151, 28);
            this.cbbMDH.TabIndex = 104;
            // 
            // buttonX1
            // 
            this.buttonX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.buttonX1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonX1.ForeColor = System.Drawing.Color.White;
            this.buttonX1.Location = new System.Drawing.Point(246, 799);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(300, 75);
            this.buttonX1.TabIndex = 103;
            this.buttonX1.Text = "Xem món ăn trong đơn";
            this.buttonX1.UseVisualStyleBackColor = false;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonS
            // 
            this.buttonS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.buttonS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonS.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonS.ForeColor = System.Drawing.Color.White;
            this.buttonS.Location = new System.Drawing.Point(246, 83);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(300, 75);
            this.buttonS.TabIndex = 102;
            this.buttonS.Text = "Đã chế biến xong";
            this.buttonS.UseVisualStyleBackColor = false;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // DATA1
            // 
            this.DATA1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DATA1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DATA1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DATA1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATA1.Location = new System.Drawing.Point(3, 187);
            this.DATA1.Name = "DATA1";
            this.DATA1.RowHeadersWidth = 51;
            this.DATA1.RowTemplate.Height = 29;
            this.DATA1.Size = new System.Drawing.Size(801, 588);
            this.DATA1.TabIndex = 46;
            this.DATA1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATA1_CellClick);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn Chưa Xử Lý";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_right
            // 
            this.panel_right.Controls.Add(this.buttonX2);
            this.panel_right.Controls.Add(this.DATA2);
            this.panel_right.Controls.Add(this.label2);
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_right.Location = new System.Drawing.Point(801, 100);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(801, 886);
            this.panel_right.TabIndex = 95;
            // 
            // buttonX2
            // 
            this.buttonX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.buttonX2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonX2.ForeColor = System.Drawing.Color.White;
            this.buttonX2.Location = new System.Drawing.Point(254, 799);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(300, 75);
            this.buttonX2.TabIndex = 104;
            this.buttonX2.Text = "Xem món ăn trong đơn";
            this.buttonX2.UseVisualStyleBackColor = false;
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // DATA2
            // 
            this.DATA2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DATA2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DATA2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DATA2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATA2.Location = new System.Drawing.Point(0, 187);
            this.DATA2.Name = "DATA2";
            this.DATA2.RowHeadersWidth = 51;
            this.DATA2.RowTemplate.Height = 29;
            this.DATA2.Size = new System.Drawing.Size(801, 588);
            this.DATA2.TabIndex = 46;
            this.DATA2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATA2_CellClick);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(801, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đơn Đã Xử Lý";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DOITAC_DH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 986);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.label3);
            this.Name = "DOITAC_DH";
            this.Text = "DOITAC_DH";
            this.Load += new System.EventHandler(this.DOITAC_DH_Load);
            this.panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DATA1)).EndInit();
            this.panel_right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DATA2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label3;
        private Panel panel_left;
        private Panel panel_right;
        private Label label1;
        private Label label2;
        private DataGridView DATA1;
        private DataGridView DATA2;
        private Button buttonS;
        private Button buttonX1;
        private Button buttonX2;
        private ComboBox cbbMDH;
    }
}