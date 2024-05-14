using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHangApp
{
	public partial class FrmLapHoaDon : Form
	{
		FrmMain frmMain;
		bool isCreatedInvoice = false;
		public FrmLapHoaDon(FrmMain frmMain)
		{
			InitializeComponent();
			this.frmMain = frmMain;
		}

		private void FrmLapHoaDon_Load(object sender, EventArgs e)
		{
			CboKhachHang.DisplayMember = "TenCty";
			CboKhachHang.ValueMember = "MaKH";
			CboKhachHang.DataSource = DataProvider.TruyVanLayDuLieu("SELECT MaKH, TenCty FROM KhachHang ORDER BY TenCty");

			var CboSanPham = DgvSanPhamMua.Columns["MaSP"] as DataGridViewComboBoxColumn;
			CboSanPham.DisplayMember = "TenSP";
			CboSanPham.ValueMember = "MaSP";
			CboSanPham.DataSource = DataProvider.TruyVanLayDuLieu("SELECT * FROM SanPham");

		}

		private void DgvSanPhamMua_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				AutoFillOrderItem(e.RowIndex);
			}
		}

		private void AutoFillOrderItem(int rowIndex)
		{
			var masp = DgvSanPhamMua.Rows[rowIndex].Cells[0].Value;
			if (masp != null)
			{
				var sanPham = DataProvider.TruyVanLayDuLieu($"SELECT * FROM SanPham WHERE MaSP='{masp}'");
				DgvSanPhamMua.Rows[rowIndex].Cells[2].Value = sanPham.Rows[0]["DonGia"].ToString();

				var soLuong = Convert.ToUInt32(DgvSanPhamMua.Rows[rowIndex].Cells[1].Value ?? 0);
				var donGia = Convert.ToDouble(DgvSanPhamMua.Rows[rowIndex].Cells[2].Value ?? 0);
				DgvSanPhamMua.Rows[rowIndex].Cells[3].Value = soLuong * donGia;
			}
		}

		private void BtnLapHoaDon_Click(object sender, EventArgs e)
		{
			if (!isCreatedInvoice)
			{
				XuLyThemHoaDon();
			}
			else
			{
				XuLyCapNhatHoaDon();
			}
			BtnLapHoaDon.Text = isCreatedInvoice ? "Cập nhật hóa đơn" : "Tạo mới hóa đơn";
		}

private void XuLyCapNhatHoaDon()
{
	var ChiTietHoaDons = new Dictionary<int, int>();
	var tongTien = 0.0;
	foreach (DataGridViewRow row in DgvSanPhamMua.Rows)
	{
		var maSp = Convert.ToInt32(row.Cells[0].Value ?? 0);
		var soLuong = Convert.ToInt32(row.Cells[1].Value ?? 0);
		var donGia = Convert.ToDouble(row.Cells[2].Value ?? 0);
		if (maSp > 0)
		{
			ChiTietHoaDons[maSp] = soLuong;
			tongTien += soLuong * donGia;
		}
	}

	if (ChiTietHoaDons.Count == 0)
	{
		MessageBox.Show("Không thể cập nhật hóa đơn không có sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		return;
	}
	var cthds = ChiTietHoaDons.Select(x => $"{x.Key},{x.Value}");


	var sqlParameters = new SqlParameter[3];
	sqlParameters[0] = new SqlParameter("MaHD", LblMaHD.Text);
	sqlParameters[1] = new SqlParameter("MaNV", frmMain.MaNV);
	sqlParameters[2] = new SqlParameter("ChiTietHD", string.Join(";", cthds));

	if (DataProvider.Execute("spCapNhatHoaDon", CommandType.StoredProcedure, sqlParameters))
	{
		MessageBox.Show("Cập nhật hóa đơn thành công!");
		LblTongTien.Text = tongTien.ToString();
	}
	else
	{
		MessageBox.Show("Cập nhật hóa đơn thất bại. Thử lại!");
	}
}

		private void XuLyThemHoaDon()
		{
			//1001,7;1003,5
			var ChiTietHoaDons = new Dictionary<int, int>();
			var tongTien = 0.0;
			foreach (DataGridViewRow row in DgvSanPhamMua.Rows)
			{
				var maSp = Convert.ToInt32(row.Cells[0].Value ?? 0);
				var soLuong = Convert.ToInt32(row.Cells[1].Value ?? 0);
				var donGia = Convert.ToDouble(row.Cells[2].Value ?? 0);
				if (maSp > 0)
				{
					ChiTietHoaDons[maSp] = soLuong;
					tongTien += soLuong * donGia;
				}
			}
			var cthds = ChiTietHoaDons.Select(x => $"{x.Key},{x.Value}");


			var sqlParameters = new SqlParameter[4];
			sqlParameters[0] = new SqlParameter("MaHD", SqlDbType.Int);
			sqlParameters[0].Direction = ParameterDirection.Output;
			sqlParameters[1] = new SqlParameter("MaKH", CboKhachHang.SelectedValue);
			sqlParameters[2] = new SqlParameter("MaNV", frmMain.MaNV);
			sqlParameters[3] = new SqlParameter("ChiTietHD", string.Join(";", cthds));

			if (DataProvider.Execute("spTaoHoaDon", CommandType.StoredProcedure, sqlParameters))
			{
				MessageBox.Show("Tạo hóa đơn thành công!");
				LblMaHD.Text = sqlParameters[0].Value.ToString();
				LblTongTien.Text = tongTien.ToString();
				isCreatedInvoice = true;
			}
			else
			{
				MessageBox.Show("Tạo hóa đơn thất bại. Thử lại!");
			}
		}
	}
}
