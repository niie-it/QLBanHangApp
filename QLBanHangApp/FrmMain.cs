using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHangApp
{
	public partial class FrmMain : Form
	{
		public FrmMain()
		{
			InitializeComponent();
		}

		private void MnuDanhMucKhachHang_Click(object sender, EventArgs e)
		{
			var f = new FrmDanhMucKhachHang();
			f.MdiParent = this;
			f.Show();
		}

		private void MnuTimKiemKhachHang_Click(object sender, EventArgs e)
		{
			var f = new FrmTimKiemKhachHang();
			f.MdiParent = this;
			f.Show();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			LblDongHo.Text = DateTime.Now.ToString("dd/MM/yyyyy HH:mm:ss");
		}

		private void MnuQuanLyKhachHang_Click(object sender, EventArgs e)
		{
			var f = new FrmQuanLyKhachHang();
			f.MdiParent = this;
			f.Show();
		}

		private void FrmMain_Load(object sender, EventArgs e)
		{
			PhanQuyen();
		}

		public bool DaDangNhap { get; set; } = false;
		public string HoTenNhanVien { get; set; }
		public string MaNV { get; set; }
		public VaiTro Quyen { get; set; }

		public void PhanQuyen()
		{
			MnuQuanLyKhachHang.Enabled = DaDangNhap;
			MnuDangXuat.Enabled = DaDangNhap;
			MnuDangNhap.Enabled = !DaDangNhap;
			LblHoTenNhanVien.Text = DaDangNhap ? $"Xin chào: {HoTenNhanVien}" : "Chưa đăng nhập";

			// xét quyền theo vai trò
			MnuCauHinhHeThong.Enabled = DaDangNhap && Quyen == VaiTro.QuanTri;
		}

		private void MnuDangNhap_Click(object sender, EventArgs e)
		{
			var f = new FrmLogin(this);
			f.MdiParent = this;
			f.Show();
		}

		private void MnuDangXuat_Click(object sender, EventArgs e)
		{
			DaDangNhap = false;
			HoTenNhanVien = string.Empty;
			PhanQuyen();

			// hủy bỏ các form con CRUD cần đăng nhập
			foreach (var form in MdiChildren)
			{
				if (form is FrmQuanLyKhachHang)
				{
					form.Close();
				}
			}
		}
	}
}
