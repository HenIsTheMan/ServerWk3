using MySql.Data.MySqlClient;
using System;

namespace ServerWk3 {
	class Database {
		MySqlConnection conn = new MySqlConnection();

		public void Connect(string host, int port, string db, string user, string password) {
			conn.ConnectionString = $"server={host};user={user};database={db};port={port};password={password}";

			conn.Open();
		}

		public void Disconnect() {
			conn.Close();
		}

		public void Query(string query) {
			try {
				MySqlCommand cmd = new MySqlCommand(query, conn);
				MySqlDataReader reader = cmd.ExecuteReader();

				if(!reader.HasRows) {
					return;
				}

				while(reader.Read()) {
					Console.WriteLine(reader[0] + ", " + reader[1] + ", " + reader[2]);
				}
			} catch(Exception e) {
				Console.WriteLine(e.ToString());
			}
		}
	}
}
