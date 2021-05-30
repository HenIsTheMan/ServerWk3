namespace ServerWk3 {
	class Program {
		static void Main(string[] args) {
			Database db = new Database();
			db.Connect("localhost", 3306, "test_db", "root", "password");
		}
	}
}
