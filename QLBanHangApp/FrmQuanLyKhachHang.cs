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
	public partial class FrmQuanLyKhachHang : Form
	{
		bool isEdit = false;

		public FrmQuanLyKhachHang()
		{
			InitializeComponent();
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void FrmQuanLyKhachHang_Load(object sender, EventArgs e)
		{
			LoadThanhPho();
			LoadKhachHang();
			SetEnable(false);
		}

		private void LoadKhachHang()
		{
			//Hiển thị hết các khách hàng
			var sql = "SELECT * FROM KhachHang ORDER BY TenCty";
			DgvKhachHang.DataSource = DataProvider.TruyVanLayDuLieu(sql);
		}

		private void LoadThanhPho()
		{
			var sql = "SELECT * FROM ThanhPho ORDER BY TenThanhPho";
			var dtThanhPho = DataProvider.TruyVanLayDuLieu(sql);


			//Đổ dữ liệu vô Combobox CboThanhPho
			CboThanhPho.DataSource = dtThanhPho;
			CboThanhPho.DisplayMember = "TenThanhPho";
			CboThanhPho.ValueMember = "MaThanhPho";

			//Đổ dữ liệu vô Combobox bên trong DataGridView
			var DgvCboThanhPho = DgvKhachHang.Columns["MaThanhPho"] as DataGridViewComboBoxColumn;
			DgvCboThanhPho.DataSource = dtThanhPho;
			DgvCboThanhPho.DisplayMember = "TenThanhPho";
			DgvCboThanhPho.ValueMember = "MaThanhPho";
		}

		/// <summary>
		/// Thay đổi trạng thái các nút nhấn
		/// </summary>
		/// <param name="enable"></param>
		void SetEnable(bool enable)
		{
			TxtMaKH.Enabled = enable;
			TxtTenCty.Enabled = enable;
			TxtDiaChi.Enabled = enable;
			CboThanhPho.Enabled = enable;
			TxtDienThoai.Enabled = enable;
			TxtMaKH.Enabled = enable;

			//set bộ nút (Thêm/Sửa trái ngược với textbox ở trên)
			BtnThem.Enabled = !enable;
			BtnSua.Enabled = !enable;

			//không cho xóa khi đang edit (enable = True)
			BtnXoa.Enabled = !isEdit;

			BtnHuy.Enabled = enable;
			BtnLuu.Enabled = enable;
		}

		private void DgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			TxtMaKH.Text = DgvKhachHang.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
			TxtTenCty.Text = DgvKhachHang.Rows[e.RowIndex].Cells["TenCty"].Value.ToString();
			TxtDiaChi.Text = DgvKhachHang.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
			TxtDienThoai.Text = DgvKhachHang.Rows[e.RowIndex].Cells["DienThoai"].Value.ToString();
			CboThanhPho.SelectedValue = DgvKhachHang.Rows[e.RowIndex].Cells["MaThanhPho"].Value.ToString();
		}

		private void BtnThem_Click(object sender, EventArgs e)
		{
			SetEnable(true);

			//xóa giá trị đang nhập
			TxtMaKH.Clear();
			TxtTenCty.Clear();
			TxtDiaChi.Clear();
			TxtDienThoai.Clear();
		}

		private void BtnSua_Click(object sender, EventArgs e)
		{
			SetEnable(true);
			isEdit = true;
			TxtMaKH.Enabled = false;
		}

		private void BtnLuu_Click(object sender, EventArgs e)
		{
			if (isEdit)//đang sửa
			{
				var sqlEdit = $"UPDATE KhachHang SET TenCty = N'{TxtTenCty.Text}', DiaChi = N'{TxtDiaChi.Text}', DienThoai = '{TxtDienThoai.Text}', MaThanhPho= '{CboThanhPho.SelectedValue}' WHERE MaKH = '{TxtMaKH.Text}'";

				DataProvider.TruyVanXuLyDuLieu(sqlEdit);
				isEdit = false;
			}
			else
			{
				var sqlInsert = $"INSERT INTO KhachHang(MaKH, TenCty, DiaChi, DienThoai, MaThanhPho) VALUES ('{TxtMaKH.Text}', N'{TxtTenCty.Text}', '{TxtDiaChi.Text}',  '{TxtDienThoai.Text}', '{CboThanhPho.SelectedValue}')";

				DataProvider.TruyVanXuLyDuLieu(sqlInsert);
			}

			LoadKhachHang();
			SetEnable(false);
		}

		private void BtnHuy_Click(object sender, EventArgs e)
		{
			isEdit = false;
			SetEnable(false);
		}

		private void BtnTaiLai_Click(object sender, EventArgs e)
		{
			LoadKhachHang();
		}

	private void BtnXoa_Click(object sender, EventArgs e)
	{
		//dựa vào textbox mã khách hàng để xóa
		if (TxtMaKH.Text == string.Empty)
		{
			MessageBox.Show("Vui lòng chọn một khách hàng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
		}
		var traLoi = MessageBox.Show("Bạn có chắc xóa khách hàng không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		if (traLoi == DialogResult.Yes)
		{
			var sqlDelete = $"DELETE FROM KhachHang WHERE MaKH = '{TxtMaKH.Text}'";
			if (DataProvider.TruyVanXuLyDuLieu(sqlDelete))
			{
				LoadKhachHang();
			}
			else
			{
				MessageBox.Show("Xóa không thành công!");
			}
		}
	}
	}
}
