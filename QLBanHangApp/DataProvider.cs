using System.Data;
using System.Data.SqlClient;

namespace QLBanHangApp
{
	public class DataProvider
	{
		public static string ChuoiKetNoi
		{
			get
			{
				return @"Server=.;Database=QLBanHang;Trusted_Connection=True;";
			}
		}

		public static DataTable TruyVanLayDuLieu(string sql)
		{
			DataTable dt = new DataTable ();
			var connection = new SqlConnection(ChuoiKetNoi);
			var dataAdapter = new SqlDataAdapter(sql, connection);
			dataAdapter.Fill(dt);
			return dt;
		}

		public static bool TruyVanXuLyDuLieu(string sql)
		{
			try
			{
				var connection = new SqlConnection(ChuoiKetNoi);
				var command = new SqlCommand(sql, connection);
				command.Connection.Open();
				command.ExecuteNonQuery();
				command.Connection.Close();
				return true;
			}
			catch(Exception ex)
			{
				//Handle error
				return false;
			}
		}
	}
}
