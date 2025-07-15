namespace DA_Winform_QLQuanCaPhe
{
    partial class frm_QuanLyMatHang
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
            this.txt_MoTa = new System.Windows.Forms.TextBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_TenSanPham = new System.Windows.Forms.TextBox();
            this.cb_MaSanPham = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_DanhMuc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_MatHang = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SoLuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MatHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MoTa.Location = new System.Drawing.Point(222, 256);
            this.txt_MoTa.Multiline = true;
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(287, 102);
            this.txt_MoTa.TabIndex = 37;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DonGia.Location = new System.Drawing.Point(222, 161);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(287, 30);
            this.txt_DonGia.TabIndex = 36;
            // 
            // txt_TenSanPham
            // 
            this.txt_TenSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSanPham.Location = new System.Drawing.Point(222, 118);
            this.txt_TenSanPham.Name = "txt_TenSanPham";
            this.txt_TenSanPham.Size = new System.Drawing.Size(287, 30);
            this.txt_TenSanPham.TabIndex = 35;
            // 
            // cb_MaSanPham
            // 
            this.cb_MaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MaSanPham.FormattingEnabled = true;
            this.cb_MaSanPham.Items.AddRange(new object[] {
            "Trà",
            "Bánh",
            "Cà phê",
            "Khác"});
            this.cb_MaSanPham.Location = new System.Drawing.Point(222, 75);
            this.cb_MaSanPham.Name = "cb_MaSanPham";
            this.cb_MaSanPham.Size = new System.Drawing.Size(287, 33);
            this.cb_MaSanPham.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 22);
            this.label8.TabIndex = 25;
            this.label8.Text = "Mã mặt hàng";
            // 
            // cb_DanhMuc
            // 
            this.cb_DanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_DanhMuc.FormattingEnabled = true;
            this.cb_DanhMuc.Items.AddRange(new object[] {
            "Trà",
            "Bánh",
            "Cà phê",
            "Khác"});
            this.cb_DanhMuc.Location = new System.Drawing.Point(222, 34);
            this.cb_DanhMuc.Name = "cb_DanhMuc";
            this.cb_DanhMuc.Size = new System.Drawing.Size(287, 33);
            this.cb_DanhMuc.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Danh mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên mặt hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Đơn giá";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(637, 547);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 88);
            this.panel2.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 27);
            this.label1.TabIndex = 29;
            this.label1.Text = "QUẢN LÝ MẶT HÀNG";
            // 
            // nud_SoLuong
            // 
            this.nud_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_SoLuong.Location = new System.Drawing.Point(222, 211);
            this.nud_SoLuong.Name = "nud_SoLuong";
            this.nud_SoLuong.Size = new System.Drawing.Size(287, 30);
            this.nud_SoLuong.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_MatHang);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 510);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách mặt hàng";
            // 
            // dgv_MatHang
            // 
            this.dgv_MatHang.BackgroundColor = System.Drawing.Color.White;
            this.dgv_MatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MatHang.GridColor = System.Drawing.Color.LightGray;
            this.dgv_MatHang.Location = new System.Drawing.Point(7, 34);
            this.dgv_MatHang.Name = "dgv_MatHang";
            this.dgv_MatHang.RowTemplate.Height = 24;
            this.dgv_MatHang.Size = new System.Drawing.Size(558, 460);
            this.dgv_MatHang.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mô tả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Số lượng tồn kho";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_MoTa);
            this.groupBox2.Controls.Add(this.txt_DonGia);
            this.groupBox2.Controls.Add(this.txt_TenSanPham);
            this.groupBox2.Controls.Add(this.cb_MaSanPham);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cb_DanhMuc);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nud_SoLuong);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(637, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 405);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // frm_QuanLyMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 692);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_QuanLyMatHang";
            this.Text = "frm_QuanLyNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.nud_SoLuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MatHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MoTa;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_TenSanPham;
        private System.Windows.Forms.ComboBox cb_MaSanPham;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_DanhMuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_SoLuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_MatHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}