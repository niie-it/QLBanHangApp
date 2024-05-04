namespace QLBanHangApp
{
	partial class FrmMain
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			menuStrip1 = new MenuStrip();
			hệThốngToolStripMenuItem = new ToolStripMenuItem();
			MnuCauHinhHeThong = new ToolStripMenuItem();
			toolStripSeparator1 = new ToolStripSeparator();
			MnuDangNhap = new ToolStripMenuItem();
			MnuDangXuat = new ToolStripMenuItem();
			toolStripSeparator2 = new ToolStripSeparator();
			thoátToolStripMenuItem = new ToolStripMenuItem();
			danhMụcToolStripMenuItem = new ToolStripMenuItem();
			thànhPhốToolStripMenuItem = new ToolStripMenuItem();
			nhânViênToolStripMenuItem = new ToolStripMenuItem();
			MnuDanhMucKhachHang = new ToolStripMenuItem();
			sảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
			quảnLýToolStripMenuItem = new ToolStripMenuItem();
			MnuQuanLyKhachHang = new ToolStripMenuItem();
			hóaĐơnToolStripMenuItem = new ToolStripMenuItem();
			hóaĐơnToolStripMenuItem1 = new ToolStripMenuItem();
			chiTiếtHóaĐơnToolStripMenuItem = new ToolStripMenuItem();
			timKiếmToolStripMenuItem = new ToolStripMenuItem();
			MnuTimKiemKhachHang = new ToolStripMenuItem();
			sảnPhẩmToolStripMenuItem1 = new ToolStripMenuItem();
			đơnHàngToolStripMenuItem = new ToolStripMenuItem();
			trợGiúpToolStripMenuItem = new ToolStripMenuItem();
			hướngDẩnSửDụngToolStripMenuItem = new ToolStripMenuItem();
			giớiThiệuChươngTrìnhToolStripMenuItem = new ToolStripMenuItem();
			statusStrip1 = new StatusStrip();
			LblDongHo = new ToolStripStatusLabel();
			LblHoTenNhanVien = new ToolStripStatusLabel();
			toolStrip1 = new ToolStrip();
			toolStripButton1 = new ToolStripButton();
			timer1 = new System.Windows.Forms.Timer(components);
			menuStrip1.SuspendLayout();
			statusStrip1.SuspendLayout();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(40, 40);
			menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, danhMụcToolStripMenuItem, quảnLýToolStripMenuItem, hóaĐơnToolStripMenuItem, timKiếmToolStripMenuItem, trợGiúpToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(2454, 52);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// hệThốngToolStripMenuItem
			// 
			hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuCauHinhHeThong, toolStripSeparator1, MnuDangNhap, MnuDangXuat, toolStripSeparator2, thoátToolStripMenuItem });
			hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
			hệThốngToolStripMenuItem.Size = new Size(167, 48);
			hệThốngToolStripMenuItem.Text = "Hệ thống";
			// 
			// MnuCauHinhHeThong
			// 
			MnuCauHinhHeThong.Name = "MnuCauHinhHeThong";
			MnuCauHinhHeThong.Size = new Size(448, 54);
			MnuCauHinhHeThong.Text = "Cấu hình Hệ thống";
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(445, 6);
			// 
			// MnuDangNhap
			// 
			MnuDangNhap.Name = "MnuDangNhap";
			MnuDangNhap.Size = new Size(448, 54);
			MnuDangNhap.Text = "Đăng nhập";
			MnuDangNhap.Click += MnuDangNhap_Click;
			// 
			// MnuDangXuat
			// 
			MnuDangXuat.Name = "MnuDangXuat";
			MnuDangXuat.Size = new Size(448, 54);
			MnuDangXuat.Text = "Đăng xuất";
			MnuDangXuat.Click += MnuDangXuat_Click;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(445, 6);
			// 
			// thoátToolStripMenuItem
			// 
			thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
			thoátToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
			thoátToolStripMenuItem.Size = new Size(448, 54);
			thoátToolStripMenuItem.Text = "Thoát";
			// 
			// danhMụcToolStripMenuItem
			// 
			danhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thànhPhốToolStripMenuItem, nhânViênToolStripMenuItem, MnuDanhMucKhachHang, sảnPhẩmToolStripMenuItem });
			danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
			danhMụcToolStripMenuItem.Size = new Size(177, 48);
			danhMụcToolStripMenuItem.Text = "Danh mục";
			// 
			// thànhPhốToolStripMenuItem
			// 
			thànhPhốToolStripMenuItem.Name = "thànhPhốToolStripMenuItem";
			thànhPhốToolStripMenuItem.Size = new Size(339, 54);
			thànhPhốToolStripMenuItem.Text = "Thành phố";
			// 
			// nhânViênToolStripMenuItem
			// 
			nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
			nhânViênToolStripMenuItem.Size = new Size(339, 54);
			nhânViênToolStripMenuItem.Text = "Nhân viên";
			// 
			// MnuDanhMucKhachHang
			// 
			MnuDanhMucKhachHang.Name = "MnuDanhMucKhachHang";
			MnuDanhMucKhachHang.Size = new Size(339, 54);
			MnuDanhMucKhachHang.Text = "Khách hàng";
			MnuDanhMucKhachHang.Click += MnuDanhMucKhachHang_Click;
			// 
			// sảnPhẩmToolStripMenuItem
			// 
			sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
			sảnPhẩmToolStripMenuItem.Size = new Size(339, 54);
			sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
			// 
			// quảnLýToolStripMenuItem
			// 
			quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuQuanLyKhachHang });
			quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
			quảnLýToolStripMenuItem.Size = new Size(144, 48);
			quảnLýToolStripMenuItem.Text = "Quản lý";
			// 
			// MnuQuanLyKhachHang
			// 
			MnuQuanLyKhachHang.Name = "MnuQuanLyKhachHang";
			MnuQuanLyKhachHang.Size = new Size(339, 54);
			MnuQuanLyKhachHang.Text = "Khách hàng";
			MnuQuanLyKhachHang.Click += MnuQuanLyKhachHang_Click;
			// 
			// hóaĐơnToolStripMenuItem
			// 
			hóaĐơnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hóaĐơnToolStripMenuItem1, chiTiếtHóaĐơnToolStripMenuItem });
			hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
			hóaĐơnToolStripMenuItem.Size = new Size(157, 48);
			hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
			// 
			// hóaĐơnToolStripMenuItem1
			// 
			hóaĐơnToolStripMenuItem1.Name = "hóaĐơnToolStripMenuItem1";
			hóaĐơnToolStripMenuItem1.Size = new Size(397, 54);
			hóaĐơnToolStripMenuItem1.Text = "Hóa đơn";
			// 
			// chiTiếtHóaĐơnToolStripMenuItem
			// 
			chiTiếtHóaĐơnToolStripMenuItem.Name = "chiTiếtHóaĐơnToolStripMenuItem";
			chiTiếtHóaĐơnToolStripMenuItem.Size = new Size(397, 54);
			chiTiếtHóaĐơnToolStripMenuItem.Text = "Chi tiết hóa đơn";
			// 
			// timKiếmToolStripMenuItem
			// 
			timKiếmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuTimKiemKhachHang, sảnPhẩmToolStripMenuItem1, đơnHàngToolStripMenuItem });
			timKiếmToolStripMenuItem.Name = "timKiếmToolStripMenuItem";
			timKiếmToolStripMenuItem.Size = new Size(163, 48);
			timKiếmToolStripMenuItem.Text = "Tim kiếm";
			// 
			// MnuTimKiemKhachHang
			// 
			MnuTimKiemKhachHang.Name = "MnuTimKiemKhachHang";
			MnuTimKiemKhachHang.Size = new Size(339, 54);
			MnuTimKiemKhachHang.Text = "Khách hàng";
			MnuTimKiemKhachHang.Click += MnuTimKiemKhachHang_Click;
			// 
			// sảnPhẩmToolStripMenuItem1
			// 
			sảnPhẩmToolStripMenuItem1.Name = "sảnPhẩmToolStripMenuItem1";
			sảnPhẩmToolStripMenuItem1.Size = new Size(339, 54);
			sảnPhẩmToolStripMenuItem1.Text = "Sản phẩm";
			// 
			// đơnHàngToolStripMenuItem
			// 
			đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
			đơnHàngToolStripMenuItem.Size = new Size(339, 54);
			đơnHàngToolStripMenuItem.Text = "Đơn hàng";
			// 
			// trợGiúpToolStripMenuItem
			// 
			trợGiúpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hướngDẩnSửDụngToolStripMenuItem, giớiThiệuChươngTrìnhToolStripMenuItem });
			trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
			trợGiúpToolStripMenuItem.Size = new Size(151, 48);
			trợGiúpToolStripMenuItem.Text = "Trợ giúp";
			// 
			// hướngDẩnSửDụngToolStripMenuItem
			// 
			hướngDẩnSửDụngToolStripMenuItem.Name = "hướngDẩnSửDụngToolStripMenuItem";
			hướngDẩnSửDụngToolStripMenuItem.Size = new Size(491, 54);
			hướngDẩnSửDụngToolStripMenuItem.Text = "Hướng dẩn sử dụng";
			// 
			// giớiThiệuChươngTrìnhToolStripMenuItem
			// 
			giớiThiệuChươngTrìnhToolStripMenuItem.Name = "giớiThiệuChươngTrìnhToolStripMenuItem";
			giớiThiệuChươngTrìnhToolStripMenuItem.Size = new Size(491, 54);
			giớiThiệuChươngTrìnhToolStripMenuItem.Text = "Giới thiệu chương trình";
			// 
			// statusStrip1
			// 
			statusStrip1.ImageScalingSize = new Size(40, 40);
			statusStrip1.Items.AddRange(new ToolStripItem[] { LblDongHo, LblHoTenNhanVien });
			statusStrip1.Location = new Point(0, 1493);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(2454, 54);
			statusStrip1.TabIndex = 1;
			statusStrip1.Text = "statusStrip1";
			// 
			// LblDongHo
			// 
			LblDongHo.Name = "LblDongHo";
			LblDongHo.Size = new Size(0, 41);
			// 
			// LblHoTenNhanVien
			// 
			LblHoTenNhanVien.Name = "LblHoTenNhanVien";
			LblHoTenNhanVien.Size = new Size(238, 41);
			LblHoTenNhanVien.Text = "Chưa đăng nhập";
			// 
			// toolStrip1
			// 
			toolStrip1.ImageScalingSize = new Size(40, 40);
			toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
			toolStrip1.Location = new Point(0, 52);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(2454, 51);
			toolStrip1.TabIndex = 2;
			toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
			toolStripButton1.ImageTransparentColor = Color.Magenta;
			toolStripButton1.Name = "toolStripButton1";
			toolStripButton1.Size = new Size(58, 44);
			toolStripButton1.Text = "toolStripButton1";
			// 
			// timer1
			// 
			timer1.Enabled = true;
			timer1.Interval = 1000;
			timer1.Tick += timer1_Tick;
			// 
			// FrmMain
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(2454, 1547);
			Controls.Add(toolStrip1);
			Controls.Add(statusStrip1);
			Controls.Add(menuStrip1);
			IsMdiContainer = true;
			MainMenuStrip = menuStrip1;
			Name = "FrmMain";
			Text = "QUẢN LÝ BÁN HÀNG";
			Load += FrmMain_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem hệThốngToolStripMenuItem;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel LblDongHo;
		private ToolStrip toolStrip1;
		private ToolStripButton toolStripButton1;
		private ToolStripMenuItem MnuCauHinhHeThong;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem MnuDangNhap;
		private ToolStripMenuItem MnuDangXuat;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripMenuItem thoátToolStripMenuItem;
		private ToolStripMenuItem danhMụcToolStripMenuItem;
		private ToolStripMenuItem thànhPhốToolStripMenuItem;
		private ToolStripMenuItem nhânViênToolStripMenuItem;
		private ToolStripMenuItem MnuDanhMucKhachHang;
		private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
		private ToolStripMenuItem hóaĐơnToolStripMenuItem;
		private ToolStripMenuItem hóaĐơnToolStripMenuItem1;
		private ToolStripMenuItem chiTiếtHóaĐơnToolStripMenuItem;
		private ToolStripMenuItem timKiếmToolStripMenuItem;
		private ToolStripMenuItem MnuTimKiemKhachHang;
		private ToolStripMenuItem sảnPhẩmToolStripMenuItem1;
		private ToolStripMenuItem đơnHàngToolStripMenuItem;
		private ToolStripMenuItem trợGiúpToolStripMenuItem;
		private ToolStripMenuItem hướngDẩnSửDụngToolStripMenuItem;
		private ToolStripMenuItem giớiThiệuChươngTrìnhToolStripMenuItem;
		private System.Windows.Forms.Timer timer1;
		private ToolStripMenuItem quảnLýToolStripMenuItem;
		private ToolStripMenuItem MnuQuanLyKhachHang;
		private ToolStripStatusLabel LblHoTenNhanVien;
	}
}