using System;

namespace ServerWk3 {
	class Program {
		static void Main(string[] args) {
			Database db = new Database();

			db.Connect("localhost", 3306, "test_db", "root", "password");

			db.Query("INSERT INTO test_db.class (id, name) VALUES (7, \"Yes\");");

			//DELETE FROM `test_db`.`class` WHERE (`id` = '5');

			string[] texts = new string[]{
				"class",
				"enrolment",
				"students"
			};
			int textsLen = texts.Length;

			for(int i = 0; i < textsLen; ++i) {
				Console.WriteLine("> SELECT * FROM " + texts[i]);
				db.Query("SELECT * FROM " + texts[i]);
				Console.WriteLine("\n\n");
			}

			//Console.WriteLine("\n\nPress the Enter key to continue...");
			//Console.ReadLine();

			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();

			//System.Threading.Thread.Sleep(1000);
		}
	}
}
