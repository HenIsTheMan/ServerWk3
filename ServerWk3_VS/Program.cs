using System;

namespace ServerWk3 {
	class Program {
		static void Main(string[] args) {
			Database db = new Database();

			db.Connect("localhost", 3306, "test_db", "root", "password");

			db.Query("SELECT * FROM students");

			//Console.WriteLine("\nPress the Enter key to continue...");
			//Console.ReadLine();

			Console.WriteLine("\nPress any key to continue...");
			Console.ReadKey();

			//System.Threading.Thread.Sleep(1000);
		}
	}
}
