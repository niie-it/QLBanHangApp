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
	public partial class FrmTimKiemKhachHang : Form
	{
		public FrmTimKiemKhachHang()
		{
			InitializeComponent();
		}

		private void FrmTimKiemKhachHang_Load(object sender, EventArgs e)
		{
			cboThanhPho.DisplayMember = "TenThanhPho";
			cboThanhPho.ValueMember = "MaThanhPho";
			cboThanhPho.DataSource = DataProvider.TruyVanLayDuLieu("SELECT * FROM ThanhPho");

			//ép chọn thành phố đầu tiên
			cboThanhPho.SelectedIndex = 0;
			layKhachHangTheoThanhPho();
		}

		private void layKhachHangTheoThanhPho()
		{
			var sql = $"SELECT * FROM KhachHang WHERE MaThanhPho='{cboThanhPho.SelectedValue.ToString()}'";
			var dtKhachHang = DataProvider.TruyVanLayDuLieu(sql);
			dgvKhachHang.DataSource = dtKhachHang;
			txtSoLuongKhachHang.Text = dtKhachHang.Rows.Count.ToString();
		}

		private void cboThanhPho_SelectedIndexChanged(object sender, EventArgs e)
		{
			layKhachHangTheoThanhPho();
		}
	}
}
