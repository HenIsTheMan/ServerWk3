using System;

namespace ServerWk3 {
	class Program {
		static void Main(string[] args) {
			Database db = new Database();

			db.Connect("localhost", 3306, "test_db", "root", "password");

			string[] texts = new string[]{
				//"class",
				"students"
			};
			int textsLen = texts.Length;

			for(int i = 0; i < textsLen; ++i) {
				Console.WriteLine("> SELECT * FROM " + texts[i] + '\n');
				db.Query("SELECT * FROM " + texts[i] + "\n\n");
			}

			//Console.WriteLine("\n\nPress the Enter key to continue...");
			//Console.ReadLine();

			Console.WriteLine("\n\nPress any key to continue...");
			Console.ReadKey();

			//System.Threading.Thread.Sleep(1000);
		}
	}
}
