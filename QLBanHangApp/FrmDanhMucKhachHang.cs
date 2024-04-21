using System.Data;
using System.Data.SqlClient;

namespace QLBanHangApp
{
	public partial class FrmDanhMucKhachHang : Form
	{
		public FrmDanhMucKhachHang()
		{
			InitializeComponent();
		}

		private void FrmDanhMucKhachHang_Load(object sender, EventArgs e)
		{
			LoadThanhPho(); // đỗ dữ liệu ThanhPho vào combobox
			LoadKhachHang(); // đỗ dữ liệu KhachHang vào datagridview
		}

		string ChuoiKetNoi = @"Server=.;Database=QLBanHang;Trusted_Connection=True;";

		private void LoadKhachHang()
		{
			var connection = new SqlConnection(ChuoiKetNoi);
			var dataAdapter = new SqlDataAdapter("SELECT * FROM KhachHang ORDER BY TenCty", connection);

			var dtKhachHang = new DataTable();
			dataAdapter.Fill(dtKhachHang);

			dgvKhachHang.DataSource = dtKhachHang;
		}

		private void LoadThanhPho()
		{
			var connection = new SqlConnection(ChuoiKetNoi);
			var dataAdapter = new SqlDataAdapter("SELECT * FROM ThanhPho ORDER BY TenThanhPho", connection);

			var dtThanhPho = new DataTable();
			dataAdapter.Fill(dtThanhPho);

			//Tìm ComboBox trong datagridview
			var cboThanhPho = dgvKhachHang.Columns["MaThanhPho"] as DataGridViewComboBoxColumn;
			cboThanhPho.DataSource = dtThanhPho;
			cboThanhPho.DisplayMember = "TenThanhPho";
			cboThanhPho.ValueMember = "MaThanhPho";
		}
	}
}
