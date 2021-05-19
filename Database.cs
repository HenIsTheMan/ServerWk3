using MySql.Data.MySqlClient;

namespace Uni {
	class Database {
		MySqlConnection conn = new MySqlConnection();

		public void Connect(string host, int port, string db, string user, string password) {
			conn.ConnectionString = $"server={host};user={user};database={db};port={port};password={password}";

			conn.Open();
		}

		public void Disconnect() {
			conn.Close();
		}
	}
}
