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
	public partial class FrmLogin : Form
	{
		private FrmMain formMain;
		public FrmLogin(FrmMain fMain)
		{
			formMain = fMain;
			InitializeComponent();
		}

		private void BtnDangNhap_Click(object sender, EventArgs e)
		{
			var sql = "SELECT CONCAT(Ho, ' ', Ten) as HoTen, MaDN, MaNV, VaiTro FROM NhanVien WHERE MaDN=@TenDN AND MatKhau=@MatKhau";
			var parameters = new SqlParameter[2];
			parameters[0] = new SqlParameter("TenDN", TxtTenDN.Text);
			parameters[1] = new SqlParameter("MatKhau", TxtMatKhau.Text);

			var dtNhanVien = DataProvider.QueryData(sql, CommandType.Text, parameters);
			if (dtNhanVien.Rows.Count > 0)
			{
				MessageBox.Show("Đăng nhập thành công");
				formMain.DaDangNhap = true;
				formMain.HoTenNhanVien = dtNhanVien.Rows[0]["HoTen"].ToString();
				formMain.MaNV = dtNhanVien.Rows[0]["MaNV"].ToString();
				formMain.Quyen = (VaiTro)dtNhanVien.Rows[0]["VaiTro"];

				formMain.PhanQuyen();
				this.Close();
			}
			else
			{
				MessageBox.Show("Đăng nhập thất bại");
			}
		}
	}
}
