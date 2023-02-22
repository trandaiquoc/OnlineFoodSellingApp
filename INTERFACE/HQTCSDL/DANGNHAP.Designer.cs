namespace HQTCSDL
{
    partial class DANGNHAP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DANGNHAP));
            this.tbMK = new System.Windows.Forms.TextBox();
            this.MATKHAU = new System.Windows.Forms.Label();
            this.tbTK = new System.Windows.Forms.TextBox();
            this.TENDANGNHAP = new System.Windows.Forms.Label();
            this.labelDN = new System.Windows.Forms.Label();
            this.hienMK = new System.Windows.Forms.PictureBox();
            this.AnMK = new System.Windows.Forms.PictureBox();
            this.QUESTION = new System.Windows.Forms.Label();
            this.DKbutton = new System.Windows.Forms.Button();
            this.DNbutton = new System.Windows.Forms.Button();
            this.exbutt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.hienMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnMK)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMK
            // 
            this.tbMK.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMK.Location = new System.Drawing.Point(86, 427);
            this.tbMK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMK.Multiline = true;
            this.tbMK.Name = "tbMK";
            this.tbMK.PasswordChar = '*';
            this.tbMK.Size = new System.Drawing.Size(511, 50);
            this.tbMK.TabIndex = 4;
            this.tbMK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMK_KeyPress);
            // 
            // MATKHAU
            // 
            this.MATKHAU.AutoSize = true;
            this.MATKHAU.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MATKHAU.Location = new System.Drawing.Point(81, 387);
            this.MATKHAU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MATKHAU.Name = "MATKHAU";
            this.MATKHAU.Size = new System.Drawing.Size(104, 27);
            this.MATKHAU.TabIndex = 8;
            this.MATKHAU.Text = "Mật khẩu";
            // 
            // tbTK
            // 
            this.tbTK.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTK.Location = new System.Drawing.Point(86, 273);
            this.tbTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTK.Multiline = true;
            this.tbTK.Name = "tbTK";
            this.tbTK.Size = new System.Drawing.Size(511, 50);
            this.tbTK.TabIndex = 7;
            // 
            // TENDANGNHAP
            // 
            this.TENDANGNHAP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TENDANGNHAP.AutoSize = true;
            this.TENDANGNHAP.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TENDANGNHAP.Location = new System.Drawing.Point(81, 233);
            this.TENDANGNHAP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TENDANGNHAP.Name = "TENDANGNHAP";
            this.TENDANGNHAP.Size = new System.Drawing.Size(156, 27);
            this.TENDANGNHAP.TabIndex = 6;
            this.TENDANGNHAP.Text = "Tên đăng nhập";
            // 
            // labelDN
            // 
            this.labelDN.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDN.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDN.Location = new System.Drawing.Point(0, 0);
            this.labelDN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDN.Name = "labelDN";
            this.labelDN.Size = new System.Drawing.Size(682, 75);
            this.labelDN.TabIndex = 5;
            this.labelDN.Text = "Đăng Nhập";
            this.labelDN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hienMK
            // 
            this.hienMK.Image = ((System.Drawing.Image)(resources.GetObject("hienMK.Image")));
            this.hienMK.Location = new System.Drawing.Point(552, 432);
            this.hienMK.Name = "hienMK";
            this.hienMK.Size = new System.Drawing.Size(40, 40);
            this.hienMK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hienMK.TabIndex = 15;
            this.hienMK.TabStop = false;
            this.hienMK.Click += new System.EventHandler(this.hienMK_Click);
            // 
            // AnMK
            // 
            this.AnMK.Image = ((System.Drawing.Image)(resources.GetObject("AnMK.Image")));
            this.AnMK.Location = new System.Drawing.Point(552, 432);
            this.AnMK.Name = "AnMK";
            this.AnMK.Size = new System.Drawing.Size(40, 40);
            this.AnMK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AnMK.TabIndex = 16;
            this.AnMK.TabStop = false;
            this.AnMK.Click += new System.EventHandler(this.AnMK_Click);
            // 
            // QUESTION
            // 
            this.QUESTION.AutoSize = true;
            this.QUESTION.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QUESTION.Location = new System.Drawing.Point(125, 670);
            this.QUESTION.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QUESTION.Name = "QUESTION";
            this.QUESTION.Size = new System.Drawing.Size(196, 27);
            this.QUESTION.TabIndex = 17;
            this.QUESTION.Text = "Chưa có tài khoản?";
            // 
            // DKbutton
            // 
            this.DKbutton.AutoSize = true;
            this.DKbutton.BackColor = System.Drawing.Color.Transparent;
            this.DKbutton.FlatAppearance.BorderSize = 0;
            this.DKbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DKbutton.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DKbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.DKbutton.Location = new System.Drawing.Point(315, 664);
            this.DKbutton.Name = "DKbutton";
            this.DKbutton.Size = new System.Drawing.Size(199, 39);
            this.DKbutton.TabIndex = 18;
            this.DKbutton.Text = "Đăng ký tài khoản";
            this.DKbutton.UseVisualStyleBackColor = false;
            this.DKbutton.Click += new System.EventHandler(this.DKbutton_Click);
            // 
            // DNbutton
            // 
            this.DNbutton.AutoSize = true;
            this.DNbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.DNbutton.FlatAppearance.BorderSize = 0;
            this.DNbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DNbutton.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DNbutton.ForeColor = System.Drawing.Color.White;
            this.DNbutton.Location = new System.Drawing.Point(175, 532);
            this.DNbutton.Name = "DNbutton";
            this.DNbutton.Size = new System.Drawing.Size(300, 50);
            this.DNbutton.TabIndex = 19;
            this.DNbutton.Text = "Đăng Nhập";
            this.DNbutton.UseVisualStyleBackColor = false;
            this.DNbutton.Click += new System.EventHandler(this.DNbutton_Click);
            // 
            // exbutt
            // 
            this.exbutt.AutoSize = true;
            this.exbutt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.exbutt.FlatAppearance.BorderSize = 0;
            this.exbutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exbutt.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exbutt.ForeColor = System.Drawing.Color.White;
            this.exbutt.Location = new System.Drawing.Point(175, 789);
            this.exbutt.Name = "exbutt";
            this.exbutt.Size = new System.Drawing.Size(300, 50);
            this.exbutt.TabIndex = 20;
            this.exbutt.Text = "Thoát";
            this.exbutt.UseVisualStyleBackColor = false;
            this.exbutt.Click += new System.EventHandler(this.exbutt_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 1055);
            this.panel1.TabIndex = 21;
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 1055);
            this.Controls.Add(this.exbutt);
            this.Controls.Add(this.DNbutton);
            this.Controls.Add(this.DKbutton);
            this.Controls.Add(this.QUESTION);
            this.Controls.Add(this.AnMK);
            this.Controls.Add(this.hienMK);
            this.Controls.Add(this.tbMK);
            this.Controls.Add(this.MATKHAU);
            this.Controls.Add(this.tbTK);
            this.Controls.Add(this.TENDANGNHAP);
            this.Controls.Add(this.labelDN);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LOGIN";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hienMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnMK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMK;
        private System.Windows.Forms.Label MATKHAU;
        private System.Windows.Forms.TextBox tbTK;
        private System.Windows.Forms.Label TENDANGNHAP;
        private System.Windows.Forms.Label labelDN;
        private PictureBox hienMK;
        private PictureBox AnMK;
        private Label QUESTION;
        private Button DKbutton;
        private Button DNbutton;
        private Button exbutt;
        private Panel panel1;
    }
}