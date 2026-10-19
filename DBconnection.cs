using System.Data.SqlClient;

namespace SkillsInternational
{
	public class DBConnection
	{
		private static string connectionString ="Data Source=DESKTOP-AUC1C8J\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True";

		public static SqlConnection GetConnection()
		{
			return new SqlConnection(connectionString);
		}
	}
}