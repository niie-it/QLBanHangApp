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
	}
}
