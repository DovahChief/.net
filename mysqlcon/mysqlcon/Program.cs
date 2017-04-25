using System;
using MySql.Data.MySqlClient;



namespace mysqlcon
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			MySql.Data.MySqlClient.MySqlConnection dbconn;
			string conn = "server=127.0.0.1;uid=accusr;" +
				"pwd=accusr;database=red_social;";


				dbconn = new MySql.Data.MySqlClient.MySqlConnection();
				dbconn.ConnectionString = conn;
				dbconn.Open();
			
			

			MySqlCommand q = dbconn.CreateCommand ();
			q.CommandText = "select * from users";
			string dr = q.ExecuteReader ().ToString ();
			dbconn.Close ();
			Console.WriteLine ($"\nDatos: \n{dr}\n");
		}
	}
}
