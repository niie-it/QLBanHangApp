using System.Configuration;
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

				//var connStr = ConfigurationManager.ConnectionStrings["MyConnStr"];
				//var myValue = ConfigurationManager.AppSettings.Get("myKey");
				return ConfigurationManager.ConnectionStrings["MyConnStr"].ToString();
			}
		}

		public static DataTable TruyVanLayDuLieu(string sql)
		{
			DataTable dt = new DataTable();
			var connection = new SqlConnection(ChuoiKetNoi);
			var dataAdapter = new SqlDataAdapter(sql, connection);
			dataAdapter.Fill(dt);
			return dt;
		}

		public static DataTable QueryData(string sql, CommandType type, SqlParameter[] parameters)
		{
			//type=CommandType.Text ==> sql = "SELECT ..."
			//type=CommandType.StoredProcedure ==> sql = "tên_storedprocedure"
			//type=CommandType.TableDirect ==> sql = "tên_bảng"
			DataTable dt = new DataTable();
			var connection = new SqlConnection(ChuoiKetNoi);
			var command = new SqlCommand();
			command.Connection = connection;
			command.CommandType = type;
			command.CommandText = sql;

			if (parameters != null)
			{
				command.Parameters.AddRange(parameters);
			}
			var dataAdapter = new SqlDataAdapter(command);
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
			catch (Exception ex)
			{
				//Handle error
				return false;
			}
		}

		public static bool Execute(string sql, CommandType type, SqlParameter[] parameters)
		{
			try
			{
				var connection = new SqlConnection(ChuoiKetNoi);
				var command = new SqlCommand
				{
					Connection = connection,
					CommandType = type,
					CommandText = sql
				};
				if (parameters != null)
				{
					command.Parameters.AddRange(parameters);
				}
				command.Connection.Open();
				command.ExecuteNonQuery();
				command.Connection.Close();
				return true;
			}
			catch (Exception ex)
			{
				//Handle error
				return false;
			}
		}
	}
}
