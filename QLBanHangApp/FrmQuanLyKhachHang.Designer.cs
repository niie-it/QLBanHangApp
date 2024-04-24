namespace QLBanHangApp
{
	partial class FrmQuanLyKhachHang
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
			splitContainer1 = new SplitContainer();
			TxtDienThoai = new TextBox();
			CboThanhPho = new ComboBox();
			TxtDiaChi = new TextBox();
			TxtTenCty = new TextBox();
			TxtMaKH = new TextBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			splitContainer2 = new SplitContainer();
			DgvKhachHang = new DataGridView();
			MaKH = new DataGridViewTextBoxColumn();
			TenCty = new DataGridViewTextBoxColumn();
			DiaChi = new DataGridViewTextBoxColumn();
			MaThanhPho = new DataGridViewComboBoxColumn();
			DienThoai = new DataGridViewTextBoxColumn();
			BtnTaiLai = new Button();
			BtnXoa = new Button();
			BtnHuy = new Button();
			BtnLuu = new Button();
			BtnSua = new Button();
			BtnThem = new Button();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
			splitContainer2.Panel1.SuspendLayout();
			splitContainer2.Panel2.SuspendLayout();
			splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)DgvKhachHang).BeginInit();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			splitContainer1.Orientation = Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(TxtDienThoai);
			splitContainer1.Panel1.Controls.Add(CboThanhPho);
			splitContainer1.Panel1.Controls.Add(TxtDiaChi);
			splitContainer1.Panel1.Controls.Add(TxtTenCty);
			splitContainer1.Panel1.Controls.Add(TxtMaKH);
			splitContainer1.Panel1.Controls.Add(label5);
			splitContainer1.Panel1.Controls.Add(label4);
			splitContainer1.Panel1.Controls.Add(label3);
			splitContainer1.Panel1.Controls.Add(label2);
			splitContainer1.Panel1.Controls.Add(label1);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(splitContainer2);
			splitContainer1.Size = new Size(1793, 1238);
			splitContainer1.SplitterDistance = 310;
			splitContainer1.TabIndex = 0;
			// 
			// TxtDienThoai
			// 
			TxtDienThoai.Font = new Font("Tahoma", 12F);
			TxtDienThoai.Location = new Point(1371, 115);
			TxtDienThoai.Name = "TxtDienThoai";
			TxtDienThoai.Size = new Size(395, 56);
			TxtDienThoai.TabIndex = 6;
			// 
			// CboThanhPho
			// 
			CboThanhPho.Font = new Font("Tahoma", 12F);
			CboThanhPho.FormattingEnabled = true;
			CboThanhPho.Location = new Point(1371, 12);
			CboThanhPho.Name = "CboThanhPho";
			CboThanhPho.Size = new Size(395, 56);
			CboThanhPho.TabIndex = 5;
			// 
			// TxtDiaChi
			// 
			TxtDiaChi.Font = new Font("Tahoma", 12F);
			TxtDiaChi.Location = new Point(197, 216);
			TxtDiaChi.Name = "TxtDiaChi";
			TxtDiaChi.Size = new Size(851, 56);
			TxtDiaChi.TabIndex = 4;
			// 
			// TxtTenCty
			// 
			TxtTenCty.Font = new Font("Tahoma", 12F);
			TxtTenCty.Location = new Point(197, 128);
			TxtTenCty.Name = "TxtTenCty";
			TxtTenCty.Size = new Size(851, 56);
			TxtTenCty.TabIndex = 3;
			// 
			// TxtMaKH
			// 
			TxtMaKH.Font = new Font("Tahoma", 12F);
			TxtMaKH.Location = new Point(197, 27);
			TxtMaKH.Name = "TxtMaKH";
			TxtMaKH.Size = new Size(851, 56);
			TxtMaKH.TabIndex = 2;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Tahoma", 12F);
			label5.Location = new Point(1130, 118);
			label5.Name = "label5";
			label5.Size = new Size(200, 48);
			label5.TabIndex = 1;
			label5.Text = "Điện thoại";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Tahoma", 12F);
			label4.Location = new Point(1130, 23);
			label4.Name = "label4";
			label4.Size = new Size(209, 48);
			label4.TabIndex = 1;
			label4.Text = "Thành phố";
			label4.Click += label4_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Tahoma", 12F);
			label3.Location = new Point(35, 128);
			label3.Name = "label3";
			label3.Size = new Size(156, 48);
			label3.TabIndex = 0;
			label3.Text = "Công ty";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Tahoma", 12F);
			label2.Location = new Point(35, 222);
			label2.Name = "label2";
			label2.Size = new Size(140, 48);
			label2.TabIndex = 0;
			label2.Text = "Địa chỉ";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 12F);
			label1.Location = new Point(35, 33);
			label1.Name = "label1";
			label1.Size = new Size(136, 48);
			label1.TabIndex = 0;
			label1.Text = "Mã KH";
			// 
			// splitContainer2
			// 
			splitContainer2.Dock = DockStyle.Fill;
			splitContainer2.Location = new Point(0, 0);
			splitContainer2.Name = "splitContainer2";
			splitContainer2.Orientation = Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			splitContainer2.Panel1.Controls.Add(DgvKhachHang);
			// 
			// splitContainer2.Panel2
			// 
			splitContainer2.Panel2.Controls.Add(BtnTaiLai);
			splitContainer2.Panel2.Controls.Add(BtnXoa);
			splitContainer2.Panel2.Controls.Add(BtnHuy);
			splitContainer2.Panel2.Controls.Add(BtnLuu);
			splitContainer2.Panel2.Controls.Add(BtnSua);
			splitContainer2.Panel2.Controls.Add(BtnThem);
			splitContainer2.Size = new Size(1793, 924);
			splitContainer2.SplitterDistance = 745;
			splitContainer2.TabIndex = 0;
			// 
			// DgvKhachHang
			// 
			DgvKhachHang.AllowUserToAddRows = false;
			DgvKhachHang.AllowUserToDeleteRows = false;
			DgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { MaKH, TenCty, DiaChi, MaThanhPho, DienThoai });
			DgvKhachHang.Dock = DockStyle.Fill;
			DgvKhachHang.Location = new Point(0, 0);
			DgvKhachHang.Name = "DgvKhachHang";
			DgvKhachHang.ReadOnly = true;
			DgvKhachHang.RowHeadersWidth = 102;
			DgvKhachHang.Size = new Size(1793, 745);
			DgvKhachHang.TabIndex = 0;
			DgvKhachHang.CellClick += DgvKhachHang_CellClick;
			// 
			// MaKH
			// 
			MaKH.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			MaKH.DataPropertyName = "MaKH";
			MaKH.HeaderText = "MÃ KH";
			MaKH.MinimumWidth = 12;
			MaKH.Name = "MaKH";
			MaKH.ReadOnly = true;
			MaKH.Width = 164;
			// 
			// TenCty
			// 
			TenCty.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			TenCty.DataPropertyName = "TenCty";
			TenCty.HeaderText = "CÔNG TY";
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
			// MaThanhPho
			// 
			MaThanhPho.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			MaThanhPho.DataPropertyName = "MaThanhPho";
			MaThanhPho.HeaderText = "THÀNH PHỐ";
			MaThanhPho.MinimumWidth = 12;
			MaThanhPho.Name = "MaThanhPho";
			MaThanhPho.ReadOnly = true;
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
			// BtnTaiLai
			// 
			BtnTaiLai.Font = new Font("Tahoma", 12F);
			BtnTaiLai.Location = new Point(1551, 46);
			BtnTaiLai.Name = "BtnTaiLai";
			BtnTaiLai.Size = new Size(215, 110);
			BtnTaiLai.TabIndex = 0;
			BtnTaiLai.Text = "Tải lại";
			BtnTaiLai.UseVisualStyleBackColor = true;
			BtnTaiLai.Click += BtnTaiLai_Click;
			// 
			// BtnXoa
			// 
			BtnXoa.Font = new Font("Tahoma", 12F);
			BtnXoa.Location = new Point(987, 46);
			BtnXoa.Name = "BtnXoa";
			BtnXoa.Size = new Size(215, 110);
			BtnXoa.TabIndex = 0;
			BtnXoa.Text = "Xóa";
			BtnXoa.UseVisualStyleBackColor = true;
			BtnXoa.Click += BtnXoa_Click;
			// 
			// BtnHuy
			// 
			BtnHuy.Font = new Font("Tahoma", 12F);
			BtnHuy.Location = new Point(750, 46);
			BtnHuy.Name = "BtnHuy";
			BtnHuy.Size = new Size(215, 110);
			BtnHuy.TabIndex = 0;
			BtnHuy.Text = "Hủy";
			BtnHuy.UseVisualStyleBackColor = true;
			BtnHuy.Click += BtnHuy_Click;
			// 
			// BtnLuu
			// 
			BtnLuu.Font = new Font("Tahoma", 12F);
			BtnLuu.Location = new Point(513, 46);
			BtnLuu.Name = "BtnLuu";
			BtnLuu.Size = new Size(215, 110);
			BtnLuu.TabIndex = 0;
			BtnLuu.Text = "Lưu";
			BtnLuu.UseVisualStyleBackColor = true;
			BtnLuu.Click += BtnLuu_Click;
			// 
			// BtnSua
			// 
			BtnSua.Font = new Font("Tahoma", 12F);
			BtnSua.Location = new Point(276, 46);
			BtnSua.Name = "BtnSua";
			BtnSua.Size = new Size(215, 110);
			BtnSua.TabIndex = 0;
			BtnSua.Text = "Sửa";
			BtnSua.UseVisualStyleBackColor = true;
			BtnSua.Click += BtnSua_Click;
			// 
			// BtnThem
			// 
			BtnThem.Font = new Font("Tahoma", 12F);
			BtnThem.Location = new Point(39, 46);
			BtnThem.Name = "BtnThem";
			BtnThem.Size = new Size(215, 110);
			BtnThem.TabIndex = 0;
			BtnThem.Text = "Thêm";
			BtnThem.UseVisualStyleBackColor = true;
			BtnThem.Click += BtnThem_Click;
			// 
			// FrmQuanLyKhachHang
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1793, 1238);
			Controls.Add(splitContainer1);
			Name = "FrmQuanLyKhachHang";
			Text = "FrmQuanLyKhachHang";
			Load += FrmQuanLyKhachHang_Load;
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel1.PerformLayout();
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			splitContainer2.Panel1.ResumeLayout(false);
			splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
			splitContainer2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)DgvKhachHang).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer splitContainer1;
		private SplitContainer splitContainer2;
		private DataGridView DgvKhachHang;
		private TextBox TxtDienThoai;
		private ComboBox CboThanhPho;
		private TextBox TxtDiaChi;
		private TextBox TxtTenCty;
		private TextBox TxtMaKH;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private Button BtnTaiLai;
		private Button BtnXoa;
		private Button BtnHuy;
		private Button BtnLuu;
		private Button BtnSua;
		private Button BtnThem;
		private DataGridViewTextBoxColumn MaKH;
		private DataGridViewTextBoxColumn TenCty;
		private DataGridViewTextBoxColumn DiaChi;
		private DataGridViewComboBoxColumn MaThanhPho;
		private DataGridViewTextBoxColumn DienThoai;
	}
}