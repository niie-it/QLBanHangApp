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
public partial class TimKiemHoaDonUserControl : UserControl
{
	public TimKiemHoaDonUserControl()
	{
		InitializeComponent();
	}

	private void TimKiemHoaDonUserControl_Load(object sender, EventArgs e)
	{
		LoadThanhPho();
		LoadNhanVien();
		LoadSanPham();
		CboThanhPho.SelectedIndex = 0; // ép chọn Thành phố đầu tiên
	}

	private void LoadSanPham()
	{
		var sql = "SELECT MaSP, TenSP FROM SanPham";

		var cboMaSP = DgvChiTietHoaDon.Columns["MaSP"] as DataGridViewComboBoxColumn;

		cboMaSP.ValueMember = "MaSP";
		cboMaSP.DisplayMember = "TenSP";
		cboMaSP.DataSource = DataProvider.TruyVanLayDuLieu(sql);
	}

	private void LoadNhanVien()
	{
		var sql = "SELECT MaNV, CONCAT(Ho, ' ', Ten) as HoTen FROM NhanVien";

		var cboMaNV = DgvHoaDon.Columns["MaNV"] as DataGridViewComboBoxColumn;

		cboMaNV.ValueMember = "MaNV";
		cboMaNV.DisplayMember = "HoTen";
		cboMaNV.DataSource = DataProvider.TruyVanLayDuLieu(sql);
	}

	private void LoadThanhPho()
	{
		var sql = "SELECT * FROM ThanhPho ORDER BY TenThanhPho";

		CboThanhPho.ValueMember = "MaThanhPho";
		CboThanhPho.DisplayMember = "TenThanhPho";
		CboThanhPho.DataSource = DataProvider.TruyVanLayDuLieu(sql);
	}

	private void LoadKhachHang()
	{
		var sql = $"SELECT MaKH, TenCty FROM KhachHang WHERE MaThanhPho='{CboThanhPho.SelectedValue}' ORDER BY TenCty";

		var dtKhachHang = DataProvider.TruyVanLayDuLieu(sql);

		CboKhachHang.ValueMember = "MaKH";
		CboKhachHang.DisplayMember = "TenCty";
		CboKhachHang.DataSource = dtKhachHang;

		TxtSoKH.Text = dtKhachHang.Rows.Count.ToString();

		//đổ dữ liệu cho column MaKH trong DgvHoaDon
		var hdCboMaKh = DgvHoaDon.Columns["MaKH"] as DataGridViewComboBoxColumn;
		hdCboMaKh.ValueMember = "MaKH";
		hdCboMaKh.DisplayMember = "TenCty";
		hdCboMaKh.DataSource = dtKhachHang;

		//Ép chọn khách hàng đầu tiên
		if (dtKhachHang.Rows.Count > 0)
		{
			CboKhachHang.SelectedIndex = 0;
		}
	}

	private void CboThanhPho_SelectedIndexChanged(object sender, EventArgs e)
	{
		LoadKhachHang();
	}

	private void CboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
	{
		LoadHoaDon();
	}

	private void LoadHoaDon()
	{
		var sql = $"SELECT * FROM HoaDon WHERE MaKH = '{CboKhachHang.SelectedValue}'";

		var dtHoaDon = DataProvider.TruyVanLayDuLieu(sql);
		DgvHoaDon.DataSource = dtHoaDon;
		TxtSoHD.Text = dtHoaDon.Rows.Count.ToString();
	}

	private void DgvHoaDon_RowEnter(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex > -1)
		{
			var sql = $"SELECT cthd.*, sp.DonGia, SoLuong * DonGia as ThanhTien FROM ChiTietHoaDon cthd JOIN SanPham sp ON cthd.MaSP = sp.MaSP WHERE MaHD = '{DgvHoaDon.Rows[e.RowIndex].Cells[0].Value}'";

			var dtCTHD = DataProvider.TruyVanLayDuLieu(sql);
			DgvChiTietHoaDon.DataSource = dtCTHD;
			TxtSoMH.Text = dtCTHD.Rows.Count.ToString();
		}
	}
}
}
