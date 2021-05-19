class Program {
	static void Main(string[] args) {
		Uni.Database db = new Uni.Database();
		db.Connect("localhost", 5055, "test_db", "Test Test", "password");
	}
}
