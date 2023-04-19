using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega.DB
{
    public class DatabaseConnection
    {
		private static SqlConnection conn = null;

		/// <summary>
		/// constructor for this class
		/// </summary>
		private DatabaseConnection()
		{

		}

		/// <summary>
		/// method for creating a db connection
		/// </summary>
		/// <returns>connection if exist</returns>
		public static SqlConnection GetInstance()
		{
			if (conn == null)
			{
				SqlConnectionStringBuilder consStringBuilder = new SqlConnectionStringBuilder();
				consStringBuilder.UserID = ReadSetting("Name");
				consStringBuilder.Password = ReadSetting("Password");
				consStringBuilder.InitialCatalog = ReadSetting("Database");
				consStringBuilder.DataSource = ReadSetting("DataSource");
				consStringBuilder.ConnectTimeout = 30;
				consStringBuilder.TrustServerCertificate = true;
				conn = new SqlConnection(consStringBuilder.ConnectionString);
				conn.Open();
			}
			return conn;
		}

		/// <summary>
		/// method for closing connection to the db
		/// </summary>
		public static void CloseConnection()
		{
			if (conn != null)
			{
				conn.Close();
				conn.Dispose();
			}
		}

		/// <summary>
		/// method for reading config info from the app.config file
		/// </summary>
		/// <param name="key">key of the value</param>
		/// <returns>value</returns>
		private static string ReadSetting(string key)
		{
			var appSettings = ConfigurationManager.AppSettings;
			string result = appSettings[key] ?? "Not Found";
			return result;
		}
	}
}
