namespace QLBanHangApp
{
	partial class FrmTimKiemKhachHang
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
			cboThanhPho = new ComboBox();
			label2 = new Label();
			txtSoLuongKhachHang = new TextBox();
			dgvKhachHang = new DataGridView();
			MaKH = new DataGridViewTextBoxColumn();
			TenCty = new DataGridViewTextBoxColumn();
			DiaChi = new DataGridViewTextBoxColumn();
			DienThoai = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial", 12F);
			label1.Location = new Point(56, 51);
			label1.Name = "label1";
			label1.Size = new Size(205, 45);
			label1.TabIndex = 0;
			label1.Text = "Thành phố";
			// 
			// cboThanhPho
			// 
			cboThanhPho.DropDownStyle = ComboBoxStyle.DropDownList;
			cboThanhPho.Font = new Font("Arial", 12F);
			cboThanhPho.FormattingEnabled = true;
			cboThanhPho.Location = new Point(304, 56);
			cboThanhPho.Name = "cboThanhPho";
			cboThanhPho.Size = new Size(453, 53);
			cboThanhPho.TabIndex = 1;
			cboThanhPho.SelectedIndexChanged += cboThanhPho_SelectedIndexChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Arial", 12F);
			label2.Location = new Point(966, 59);
			label2.Name = "label2";
			label2.Size = new Size(373, 45);
			label2.TabIndex = 2;
			label2.Text = "Tồng số khách hàng";
			// 
			// txtSoLuongKhachHang
			// 
			txtSoLuongKhachHang.Enabled = false;
			txtSoLuongKhachHang.Font = new Font("Arial", 12F);
			txtSoLuongKhachHang.ForeColor = Color.Red;
			txtSoLuongKhachHang.Location = new Point(1352, 56);
			txtSoLuongKhachHang.Name = "txtSoLuongKhachHang";
			txtSoLuongKhachHang.Size = new Size(250, 53);
			txtSoLuongKhachHang.TabIndex = 3;
			// 
			// dgvKhachHang
			// 
			dgvKhachHang.AllowUserToAddRows = false;
			dgvKhachHang.AllowUserToDeleteRows = false;
			dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { MaKH, TenCty, DiaChi, DienThoai });
			dgvKhachHang.Location = new Point(12, 228);
			dgvKhachHang.Name = "dgvKhachHang";
			dgvKhachHang.ReadOnly = true;
			dgvKhachHang.RowHeadersWidth = 102;
			dgvKhachHang.Size = new Size(1611, 678);
			dgvKhachHang.TabIndex = 4;
			// 
			// MaKH
			// 
			MaKH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			MaKH.DataPropertyName = "MaKH";
			MaKH.HeaderText = "Mã KH";
			MaKH.MinimumWidth = 12;
			MaKH.Name = "MaKH";
			MaKH.ReadOnly = true;
			// 
			// TenCty
			// 
			TenCty.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			TenCty.DataPropertyName = "TenCty";
			TenCty.HeaderText = "Khách hàng";
			TenCty.MinimumWidth = 12;
			TenCty.Name = "TenCty";
			TenCty.ReadOnly = true;
			// 
			// DiaChi
			// 
			DiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			DiaChi.DataPropertyName = "DiaChi";
			DiaChi.HeaderText = "Địa chĩ";
			DiaChi.MinimumWidth = 12;
			DiaChi.Name = "DiaChi";
			DiaChi.ReadOnly = true;
			// 
			// DienThoai
			// 
			DienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			DienThoai.DataPropertyName = "DienThoai";
			DienThoai.HeaderText = "Điện thoại";
			DienThoai.MinimumWidth = 12;
			DienThoai.Name = "DienThoai";
			DienThoai.ReadOnly = true;
			// 
			// FrmTimKiemKhachHang
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1644, 910);
			Controls.Add(dgvKhachHang);
			Controls.Add(txtSoLuongKhachHang);
			Controls.Add(label2);
			Controls.Add(cboThanhPho);
			Controls.Add(label1);
			Name = "FrmTimKiemKhachHang";
			Text = "FrmTimKiemKhachHang";
			Load += FrmTimKiemKhachHang_Load;
			((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private ComboBox cboThanhPho;
		private Label label2;
		private TextBox txtSoLuongKhachHang;
		private DataGridView dgvKhachHang;
		private DataGridViewTextBoxColumn MaKH;
		private DataGridViewTextBoxColumn TenCty;
		private DataGridViewTextBoxColumn DiaChi;
		private DataGridViewTextBoxColumn DienThoai;
	}
}