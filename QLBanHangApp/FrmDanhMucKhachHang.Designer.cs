namespace QLBanHangApp
{
	partial class FrmDanhMucKhachHang
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			dgvKhachHang = new DataGridView();
			MaKH = new DataGridViewTextBoxColumn();
			TenCty = new DataGridViewTextBoxColumn();
			DiaChi = new DataGridViewTextBoxColumn();
			DienThoai = new DataGridViewTextBoxColumn();
			MaThanhPho = new DataGridViewComboBoxColumn();
			((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
			SuspendLayout();
			// 
			// dgvKhachHang
			// 
			dgvKhachHang.AllowUserToAddRows = false;
			dgvKhachHang.AllowUserToDeleteRows = false;
			dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { MaKH, TenCty, DiaChi, DienThoai, MaThanhPho });
			dgvKhachHang.Dock = DockStyle.Fill;
			dgvKhachHang.Location = new Point(0, 0);
			dgvKhachHang.Name = "dgvKhachHang";
			dgvKhachHang.ReadOnly = true;
			dgvKhachHang.RowHeadersWidth = 102;
			dgvKhachHang.Size = new Size(1779, 893);
			dgvKhachHang.TabIndex = 0;
			// 
			// MaKH
			// 
			MaKH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			MaKH.DataPropertyName = "MaKH";
			MaKH.HeaderText = "MÃ KH";
			MaKH.MinimumWidth = 12;
			MaKH.Name = "MaKH";
			MaKH.ReadOnly = true;
			// 
			// TenCty
			// 
			TenCty.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			TenCty.DataPropertyName = "TenCty";
			TenCty.HeaderText = "KHÁCH HÀNG";
			TenCty.MinimumWidth = 12;
			TenCty.Name = "TenCty";
			TenCty.ReadOnly = true;
			// 
			// DiaChi
			// 
			DiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			DiaChi.DataPropertyName = "DiaChi";
			DiaChi.HeaderText = "ĐỊA CHỈ";
			DiaChi.MinimumWidth = 12;
			DiaChi.Name = "DiaChi";
			DiaChi.ReadOnly = true;
			// 
			// DienThoai
			// 
			DienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			DienThoai.DataPropertyName = "DienThoai";
			DienThoai.HeaderText = "ĐIỆN THOẠI";
			DienThoai.MinimumWidth = 12;
			DienThoai.Name = "DienThoai";
			DienThoai.ReadOnly = true;
			// 
			// MaThanhPho
			// 
			MaThanhPho.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			MaThanhPho.DataPropertyName = "MaThanhPho";
			MaThanhPho.HeaderText = "THÀNH PHỐ";
			MaThanhPho.MinimumWidth = 12;
			MaThanhPho.Name = "MaThanhPho";
			MaThanhPho.ReadOnly = true;
			// 
			// FrmDanhMucKhachHang
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1779, 893);
			Controls.Add(dgvKhachHang);
			Name = "FrmDanhMucKhachHang";
			Text = "DANH MỤC KHÁCH HÀNG";
			Load += FrmDanhMucKhachHang_Load;
			((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvKhachHang;
		private DataGridViewTextBoxColumn MaKH;
		private DataGridViewTextBoxColumn TenCty;
		private DataGridViewTextBoxColumn DiaChi;
		private DataGridViewTextBoxColumn DienThoai;
		private DataGridViewComboBoxColumn MaThanhPho;
	}
}
