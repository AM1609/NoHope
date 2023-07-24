namespace QuanlyCoffee
{
    partial class frmMain
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
            this.btnSanpham = new System.Windows.Forms.Button();
            this.btnThuchi = new System.Windows.Forms.Button();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.btnCa = new System.Windows.Forms.Button();
            this.btnThongke = new System.Windows.Forms.Button();
            this.btnKho = new System.Windows.Forms.Button();
            this.btnNhanvien = new System.Windows.Forms.Button();
            this.btnDangxuat = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
            this.panelbody = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSanpham
            // 
            this.btnSanpham.Location = new System.Drawing.Point(244, 1);
            this.btnSanpham.Name = "btnSanpham";
            this.btnSanpham.Size = new System.Drawing.Size(120, 47);
            this.btnSanpham.TabIndex = 0;
            this.btnSanpham.Text = "Sản phẩm";
            this.btnSanpham.UseVisualStyleBackColor = true;
            this.btnSanpham.Click += new System.EventHandler(this.btnsanpham_Click);
            // 
            // btnThuchi
            // 
            this.btnThuchi.Location = new System.Drawing.Point(2, 333);
            this.btnThuchi.Name = "btnThuchi";
            this.btnThuchi.Size = new System.Drawing.Size(104, 60);
            this.btnThuchi.TabIndex = 1;
            this.btnThuchi.Text = "Thu chi";
            this.btnThuchi.UseVisualStyleBackColor = true;
            this.btnThuchi.Click += new System.EventHandler(this.btnThuchi_Click);
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Location = new System.Drawing.Point(2, 201);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(104, 60);
            this.btnThanhtoan.TabIndex = 2;
            this.btnThanhtoan.Text = "Thanh toán";
            this.btnThanhtoan.UseVisualStyleBackColor = true;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // btnCa
            // 
            this.btnCa.Location = new System.Drawing.Point(2, 267);
            this.btnCa.Name = "btnCa";
            this.btnCa.Size = new System.Drawing.Size(104, 60);
            this.btnCa.TabIndex = 3;
            this.btnCa.Text = "Quản lý ca";
            this.btnCa.UseVisualStyleBackColor = true;
            this.btnCa.Click += new System.EventHandler(this.btnCa_Click);
            // 
            // btnThongke
            // 
            this.btnThongke.Location = new System.Drawing.Point(2, 135);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(104, 60);
            this.btnThongke.TabIndex = 4;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // btnKho
            // 
            this.btnKho.Location = new System.Drawing.Point(2, 399);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(104, 60);
            this.btnKho.TabIndex = 5;
            this.btnKho.Text = "Quản lý kho";
            this.btnKho.UseVisualStyleBackColor = true;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.Location = new System.Drawing.Point(2, 465);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(104, 60);
            this.btnNhanvien.TabIndex = 6;
            this.btnNhanvien.Text = "Nhân viên";
            this.btnNhanvien.UseVisualStyleBackColor = true;
            this.btnNhanvien.Click += new System.EventHandler(this.btnNhanvien_Click);
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.Location = new System.Drawing.Point(2, 531);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(104, 60);
            this.btnDangxuat.TabIndex = 7;
            this.btnDangxuat.Text = "Đăng xuất";
            this.btnDangxuat.UseVisualStyleBackColor = true;
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            // 
            // btnBan
            // 
            this.btnBan.Location = new System.Drawing.Point(118, 1);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(120, 47);
            this.btnBan.TabIndex = 8;
            this.btnBan.Text = "Quản lý bàn";
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // panelbody
            // 
            this.panelbody.Location = new System.Drawing.Point(112, 47);
            this.panelbody.Name = "panelbody";
            this.panelbody.Size = new System.Drawing.Size(853, 587);
            this.panelbody.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanlyCoffee.Properties.Resources.unknown_11;
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 592);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelbody);
            this.Controls.Add(this.btnBan);
            this.Controls.Add(this.btnDangxuat);
            this.Controls.Add(this.btnNhanvien);
            this.Controls.Add(this.btnKho);
            this.Controls.Add(this.btnThongke);
            this.Controls.Add(this.btnCa);
            this.Controls.Add(this.btnThanhtoan);
            this.Controls.Add(this.btnThuchi);
            this.Controls.Add(this.btnSanpham);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSanpham;
        private System.Windows.Forms.Button btnThuchi;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.Button btnCa;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Button btnKho;
        private System.Windows.Forms.Button btnNhanvien;
        private System.Windows.Forms.Button btnDangxuat;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.Panel panelbody;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}