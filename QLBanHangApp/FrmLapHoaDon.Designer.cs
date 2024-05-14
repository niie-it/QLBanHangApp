namespace QLBanHangApp
{
	partial class FrmLapHoaDon
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
			label1 = new Label();
			label2 = new Label();
			CboKhachHang = new ComboBox();
			BtnThemKH = new Button();
			groupBox1 = new GroupBox();
			DgvSanPhamMua = new DataGridView();
			MaSP = new DataGridViewComboBoxColumn();
			SoLuong = new DataGridViewTextBoxColumn();
			DonGia = new DataGridViewTextBoxColumn();
			ThanhTien = new DataGridViewTextBoxColumn();
			label3 = new Label();
			LblMaHD = new Label();
			label5 = new Label();
			LblTongTien = new Label();
			BtnLapHoaDon = new Button();
			BtnInHoaDon = new Button();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)DgvSanPhamMua).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 22F);
			label1.Location = new Point(354, 36);
			label1.Name = "label1";
			label1.Size = new Size(884, 89);
			label1.TabIndex = 0;
			label1.Text = "LẬP HÓA ĐƠN BÁN HÀNG";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Tahoma", 12F);
			label2.Location = new Point(64, 195);
			label2.Name = "label2";
			label2.Size = new Size(227, 48);
			label2.TabIndex = 1;
			label2.Text = "Khách hàng";
			// 
			// CboKhachHang
			// 
			CboKhachHang.Font = new Font("Tahoma", 12F);
			CboKhachHang.FormattingEnabled = true;
			CboKhachHang.Location = new Point(312, 187);
			CboKhachHang.Name = "CboKhachHang";
			CboKhachHang.Size = new Size(785, 56);
			CboKhachHang.TabIndex = 2;
			// 
			// BtnThemKH
			// 
			BtnThemKH.Font = new Font("Tahoma", 12F);
			BtnThemKH.Location = new Point(1167, 178);
			BtnThemKH.Name = "BtnThemKH";
			BtnThemKH.Size = new Size(267, 71);
			BtnThemKH.TabIndex = 3;
			BtnThemKH.Text = "Thêm KH";
			BtnThemKH.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(DgvSanPhamMua);
			groupBox1.Font = new Font("Tahoma", 12F);
			groupBox1.Location = new Point(61, 353);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(1468, 658);
			groupBox1.TabIndex = 4;
			groupBox1.TabStop = false;
			groupBox1.Text = "Sản phẩm mua";
			// 
			// DgvSanPhamMua
			// 
			DgvSanPhamMua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DgvSanPhamMua.Columns.AddRange(new DataGridViewColumn[] { MaSP, SoLuong, DonGia, ThanhTien });
			DgvSanPhamMua.Dock = DockStyle.Fill;
			DgvSanPhamMua.Location = new Point(3, 52);
			DgvSanPhamMua.Name = "DgvSanPhamMua";
			DgvSanPhamMua.RowHeadersWidth = 102;
			DgvSanPhamMua.Size = new Size(1462, 603);
			DgvSanPhamMua.TabIndex = 0;
			DgvSanPhamMua.CellValueChanged += DgvSanPhamMua_CellValueChanged;
			// 
			// MaSP
			// 
			MaSP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			MaSP.DataPropertyName = "MaSP";
			MaSP.HeaderText = "Sản phẩm";
			MaSP.MinimumWidth = 12;
			MaSP.Name = "MaSP";
			// 
			// SoLuong
			// 
			SoLuong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			SoLuong.DataPropertyName = "SoLuong";
			SoLuong.HeaderText = "Số lượng";
			SoLuong.MinimumWidth = 12;
			SoLuong.Name = "SoLuong";
			// 
			// DonGia
			// 
			DonGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			DonGia.DataPropertyName = "DonGia";
			DonGia.HeaderText = "Đơn giá";
			DonGia.MinimumWidth = 12;
			DonGia.Name = "DonGia";
			DonGia.ReadOnly = true;
			// 
			// ThanhTien
			// 
			ThanhTien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			ThanhTien.DataPropertyName = "ThanhTien";
			ThanhTien.HeaderText = "Thành tiền";
			ThanhTien.MinimumWidth = 12;
			ThanhTien.Name = "ThanhTien";
			ThanhTien.ReadOnly = true;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Tahoma", 12F);
			label3.Location = new Point(64, 273);
			label3.Name = "label3";
			label3.Size = new Size(231, 48);
			label3.TabIndex = 5;
			label3.Text = "Mã hóa đơn";
			// 
			// LblMaHD
			// 
			LblMaHD.AutoSize = true;
			LblMaHD.Font = new Font("Tahoma", 12F, FontStyle.Bold);
			LblMaHD.ForeColor = Color.Red;
			LblMaHD.Location = new Point(312, 273);
			LblMaHD.Name = "LblMaHD";
			LblMaHD.Size = new Size(142, 48);
			LblMaHD.TabIndex = 6;
			LblMaHD.Text = "label4";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Tahoma", 12F);
			label5.Location = new Point(1083, 1045);
			label5.Name = "label5";
			label5.Size = new Size(187, 48);
			label5.TabIndex = 5;
			label5.Text = "Tổng tiền";
			// 
			// LblTongTien
			// 
			LblTongTien.AutoSize = true;
			LblTongTien.Font = new Font("Tahoma", 12F, FontStyle.Bold);
			LblTongTien.ForeColor = Color.Red;
			LblTongTien.Location = new Point(1331, 1045);
			LblTongTien.Name = "LblTongTien";
			LblTongTien.Size = new Size(45, 48);
			LblTongTien.TabIndex = 6;
			LblTongTien.Text = "0";
			// 
			// BtnLapHoaDon
			// 
			BtnLapHoaDon.Font = new Font("Tahoma", 12F);
			BtnLapHoaDon.Location = new Point(64, 1157);
			BtnLapHoaDon.Name = "BtnLapHoaDon";
			BtnLapHoaDon.Size = new Size(353, 118);
			BtnLapHoaDon.TabIndex = 7;
			BtnLapHoaDon.Text = "Tạo mới hóa đơn";
			BtnLapHoaDon.UseVisualStyleBackColor = true;
			BtnLapHoaDon.Click += BtnLapHoaDon_Click;
			// 
			// BtnInHoaDon
			// 
			BtnInHoaDon.Font = new Font("Tahoma", 12F);
			BtnInHoaDon.Location = new Point(1167, 1157);
			BtnInHoaDon.Name = "BtnInHoaDon";
			BtnInHoaDon.Size = new Size(353, 118);
			BtnInHoaDon.TabIndex = 7;
			BtnInHoaDon.Text = "In hóa đơn";
			BtnInHoaDon.UseVisualStyleBackColor = true;
			// 
			// FrmLapHoaDon
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1605, 1326);
			Controls.Add(BtnInHoaDon);
			Controls.Add(BtnLapHoaDon);
			Controls.Add(LblTongTien);
			Controls.Add(label5);
			Controls.Add(LblMaHD);
			Controls.Add(label3);
			Controls.Add(groupBox1);
			Controls.Add(BtnThemKH);
			Controls.Add(CboKhachHang);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "FrmLapHoaDon";
			Text = "FrmLapHoaDon";
			Load += FrmLapHoaDon_Load;
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)DgvSanPhamMua).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private ComboBox CboKhachHang;
		private Button BtnThemKH;
		private GroupBox groupBox1;
		private DataGridView DgvSanPhamMua;
		private Label label3;
		private Label LblMaHD;
		private Label label5;
		private Label LblTongTien;
		private Button BtnLapHoaDon;
		private Button BtnInHoaDon;
		private DataGridViewComboBoxColumn MaSP;
		private DataGridViewTextBoxColumn SoLuong;
		private DataGridViewTextBoxColumn DonGia;
		private DataGridViewTextBoxColumn ThanhTien;
	}
}