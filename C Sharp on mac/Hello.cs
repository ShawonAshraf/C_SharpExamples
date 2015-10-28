using System;

namespace HelloMac
{
	public class Hello
	{
		public static int Main()
		{
			// for new line 
			Console.WriteLine();
			
			Console.WriteLine("Hello Mac! This is C# !");
			Console.WriteLine(); // this too for new line, makes things clear
			
			// a little tidying up!
			Console.WriteLine("Press any key to exit ... ... ...");
			Console.ReadLine();
			
			return 0;
		}
	}
}