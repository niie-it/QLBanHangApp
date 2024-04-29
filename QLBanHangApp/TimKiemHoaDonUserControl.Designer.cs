namespace QLBanHangApp
{
	partial class TimKiemHoaDonUserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			CboThanhPho = new ComboBox();
			label2 = new Label();
			CboKhachHang = new ComboBox();
			label3 = new Label();
			TxtSoKH = new TextBox();
			groupBox1 = new GroupBox();
			DgvHoaDon = new DataGridView();
			MAHD = new DataGridViewTextBoxColumn();
			MaKH = new DataGridViewComboBoxColumn();
			NgayLapHD = new DataGridViewTextBoxColumn();
			NgayNhanHang = new DataGridViewTextBoxColumn();
			MaNV = new DataGridViewComboBoxColumn();
			label4 = new Label();
			TxtSoHD = new TextBox();
			groupBox2 = new GroupBox();
			DgvChiTietHoaDon = new DataGridView();
			label5 = new Label();
			TxtSoMH = new TextBox();
			CtHdMaHD = new DataGridViewTextBoxColumn();
			MaSP = new DataGridViewComboBoxColumn();
			SoLuong = new DataGridViewTextBoxColumn();
			DonGia = new DataGridViewTextBoxColumn();
			ThanhTien = new DataGridViewTextBoxColumn();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)DgvHoaDon).BeginInit();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)DgvChiTietHoaDon).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 12F);
			label1.Location = new Point(30, 30);
			label1.Name = "label1";
			label1.Size = new Size(209, 48);
			label1.TabIndex = 0;
			label1.Text = "Thành phố";
			// 
			// CboThanhPho
			// 
			CboThanhPho.DropDownStyle = ComboBoxStyle.DropDownList;
			CboThanhPho.Font = new Font("Tahoma", 12F);
			CboThanhPho.FormattingEnabled = true;
			CboThanhPho.Location = new Point(267, 22);
			CboThanhPho.Name = "CboThanhPho";
			CboThanhPho.Size = new Size(358, 56);
			CboThanhPho.TabIndex = 1;
			CboThanhPho.SelectedIndexChanged += CboThanhPho_SelectedIndexChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Tahoma", 12F);
			label2.Location = new Point(646, 25);
			label2.Name = "label2";
			label2.Size = new Size(227, 48);
			label2.TabIndex = 2;
			label2.Text = "Khách hàng";
			// 
			// CboKhachHang
			// 
			CboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
			CboKhachHang.Font = new Font("Tahoma", 12F);
			CboKhachHang.FormattingEnabled = true;
			CboKhachHang.Location = new Point(879, 20);
			CboKhachHang.Name = "CboKhachHang";
			CboKhachHang.Size = new Size(484, 56);
			CboKhachHang.TabIndex = 3;
			CboKhachHang.SelectedIndexChanged += CboKhachHang_SelectedIndexChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Tahoma", 12F);
			label3.Location = new Point(1388, 20);
			label3.Name = "label3";
			label3.Size = new Size(393, 48);
			label3.TabIndex = 4;
			label3.Text = "Số lượng khách hàng";
			// 
			// TxtSoKH
			// 
			TxtSoKH.Enabled = false;
			TxtSoKH.Font = new Font("Tahoma", 12F);
			TxtSoKH.ForeColor = Color.FromArgb(0, 0, 192);
			TxtSoKH.Location = new Point(1787, 17);
			TxtSoKH.Name = "TxtSoKH";
			TxtSoKH.Size = new Size(165, 56);
			TxtSoKH.TabIndex = 5;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(DgvHoaDon);
			groupBox1.Font = new Font("Tahoma", 12F);
			groupBox1.Location = new Point(30, 142);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(1922, 471);
			groupBox1.TabIndex = 6;
			groupBox1.TabStop = false;
			groupBox1.Text = "Danh sách đơn hàng";
			// 
			// DgvHoaDon
			// 
			DgvHoaDon.AllowUserToAddRows = false;
			DgvHoaDon.AllowUserToDeleteRows = false;
			DgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { MAHD, MaKH, NgayLapHD, NgayNhanHang, MaNV });
			DgvHoaDon.Dock = DockStyle.Fill;
			DgvHoaDon.Location = new Point(3, 52);
			DgvHoaDon.Name = "DgvHoaDon";
			DgvHoaDon.ReadOnly = true;
			DgvHoaDon.RowHeadersWidth = 102;
			DgvHoaDon.Size = new Size(1916, 416);
			DgvHoaDon.TabIndex = 0;
			DgvHoaDon.CellClick += DgvHoaDon_CellClick;
			DgvHoaDon.RowEnter += DgvHoaDon_RowEnter;
			// 
			// MAHD
			// 
			MAHD.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			MAHD.DataPropertyName = "MaHD";
			MAHD.HeaderText = "Mã HĐ";
			MAHD.MinimumWidth = 12;
			MAHD.Name = "MAHD";
			MAHD.ReadOnly = true;
			// 
			// MaKH
			// 
			MaKH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			MaKH.DataPropertyName = "MaKH";
			MaKH.HeaderText = "Khách hàng";
			MaKH.MinimumWidth = 12;
			MaKH.Name = "MaKH";
			MaKH.ReadOnly = true;
			// 
			// NgayLapHD
			// 
			NgayLapHD.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			NgayLapHD.DataPropertyName = "NgayLapHD";
			NgayLapHD.HeaderText = "Ngày lập HĐ";
			NgayLapHD.MinimumWidth = 12;
			NgayLapHD.Name = "NgayLapHD";
			NgayLapHD.ReadOnly = true;
			NgayLapHD.Resizable = DataGridViewTriState.True;
			NgayLapHD.SortMode = DataGridViewColumnSortMode.NotSortable;
			// 
			// NgayNhanHang
			// 
			NgayNhanHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			NgayNhanHang.DataPropertyName = "NgayNhanHang";
			NgayNhanHang.HeaderText = "Ngày nhận hàng";
			NgayNhanHang.MinimumWidth = 12;
			NgayNhanHang.Name = "NgayNhanHang";
			NgayNhanHang.ReadOnly = true;
			NgayNhanHang.Width = 333;
			// 
			// MaNV
			// 
			MaNV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			MaNV.DataPropertyName = "MaNV";
			MaNV.HeaderText = "Nhân viên lập HĐ";
			MaNV.MinimumWidth = 12;
			MaNV.Name = "MaNV";
			MaNV.ReadOnly = true;
			MaNV.Resizable = DataGridViewTriState.True;
			MaNV.SortMode = DataGridViewColumnSortMode.Automatic;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Tahoma", 12F);
			label4.Location = new Point(1445, 666);
			label4.Name = "label4";
			label4.Size = new Size(336, 48);
			label4.TabIndex = 4;
			label4.Text = "Số lượng hóa đơn";
			// 
			// TxtSoHD
			// 
			TxtSoHD.Enabled = false;
			TxtSoHD.Font = new Font("Tahoma", 12F);
			TxtSoHD.ForeColor = Color.FromArgb(0, 0, 192);
			TxtSoHD.Location = new Point(1787, 666);
			TxtSoHD.Name = "TxtSoHD";
			TxtSoHD.Size = new Size(165, 56);
			TxtSoHD.TabIndex = 5;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(DgvChiTietHoaDon);
			groupBox2.Font = new Font("Tahoma", 12F);
			groupBox2.Location = new Point(30, 784);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(1922, 471);
			groupBox2.TabIndex = 6;
			groupBox2.TabStop = false;
			groupBox2.Text = "Chi tiết đơn hàng";
			// 
			// DgvChiTietHoaDon
			// 
			DgvChiTietHoaDon.AllowUserToAddRows = false;
			DgvChiTietHoaDon.AllowUserToDeleteRows = false;
			DgvChiTietHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DgvChiTietHoaDon.Columns.AddRange(new DataGridViewColumn[] { CtHdMaHD, MaSP, SoLuong, DonGia, ThanhTien });
			DgvChiTietHoaDon.Dock = DockStyle.Fill;
			DgvChiTietHoaDon.Location = new Point(3, 52);
			DgvChiTietHoaDon.Name = "DgvChiTietHoaDon";
			DgvChiTietHoaDon.ReadOnly = true;
			DgvChiTietHoaDon.RowHeadersWidth = 102;
			DgvChiTietHoaDon.Size = new Size(1916, 416);
			DgvChiTietHoaDon.TabIndex = 0;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Tahoma", 12F);
			label5.Location = new Point(1423, 1297);
			label5.Name = "label5";
			label5.Size = new Size(358, 48);
			label5.TabIndex = 4;
			label5.Text = "Số lượng mặt hàng";
			// 
			// TxtSoMH
			// 
			TxtSoMH.Enabled = false;
			TxtSoMH.Font = new Font("Tahoma", 12F);
			TxtSoMH.ForeColor = Color.FromArgb(0, 0, 192);
			TxtSoMH.Location = new Point(1787, 1297);
			TxtSoMH.Name = "TxtSoMH";
			TxtSoMH.Size = new Size(165, 56);
			TxtSoMH.TabIndex = 5;
			// 
			// CtHdMaHD
			// 
			CtHdMaHD.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			CtHdMaHD.DataPropertyName = "MaHD";
			CtHdMaHD.HeaderText = "Mã HĐ";
			CtHdMaHD.MinimumWidth = 12;
			CtHdMaHD.Name = "CtHdMaHD";
			CtHdMaHD.ReadOnly = true;
			// 
			// MaSP
			// 
			MaSP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			MaSP.DataPropertyName = "MaSP";
			MaSP.HeaderText = "Sản phẩm";
			MaSP.MinimumWidth = 12;
			MaSP.Name = "MaSP";
			MaSP.ReadOnly = true;
			// 
			// SoLuong
			// 
			SoLuong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			SoLuong.DataPropertyName = "SoLuong";
			SoLuong.HeaderText = "Số lượng";
			SoLuong.MinimumWidth = 12;
			SoLuong.Name = "SoLuong";
			SoLuong.ReadOnly = true;
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
			// TimKiemHoaDonUserControl
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(TxtSoMH);
			Controls.Add(label5);
			Controls.Add(TxtSoHD);
			Controls.Add(label4);
			Controls.Add(TxtSoKH);
			Controls.Add(label3);
			Controls.Add(CboKhachHang);
			Controls.Add(label2);
			Controls.Add(CboThanhPho);
			Controls.Add(label1);
			Name = "TimKiemHoaDonUserControl";
			Size = new Size(1994, 1390);
			Load += TimKiemHoaDonUserControl_Load;
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)DgvHoaDon).EndInit();
			groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)DgvChiTietHoaDon).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private ComboBox CboThanhPho;
		private Label label2;
		private ComboBox CboKhachHang;
		private Label label3;
		private TextBox TxtSoKH;
		private GroupBox groupBox1;
		private Label label4;
		private TextBox TxtSoHD;
		private GroupBox groupBox2;
		private Label label5;
		private TextBox TxtSoMH;
		private DataGridView DgvHoaDon;
		private DataGridView DgvChiTietHoaDon;
		private DataGridViewTextBoxColumn MAHD;
		private DataGridViewComboBoxColumn MaKH;
		private DataGridViewTextBoxColumn NgayLapHD;
		private DataGridViewTextBoxColumn NgayNhanHang;
		private DataGridViewComboBoxColumn MaNV;
		private DataGridViewTextBoxColumn CtHdMaHD;
		private DataGridViewComboBoxColumn MaSP;
		private DataGridViewTextBoxColumn SoLuong;
		private DataGridViewTextBoxColumn DonGia;
		private DataGridViewTextBoxColumn ThanhTien;
	}
}
